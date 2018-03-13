using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing.Imaging;
using System.Text;
using System.Windows;
using System.Windows.Forms;
using System.IO;
using System.Windows.Media.Imaging;
using AForge;
using AForge.Controls;
using AForge.Video;
using AForge.Video.DirectShow;
using Size = System.Drawing.Size;

//using DllImport;
using System.Runtime.InteropServices;

namespace OperateCamera
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection videoDevices;
        private VideoCaptureDevice videoSource;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            try
            {
                // 枚举所有视频输入设备
                videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);

                if (videoDevices.Count == 0)
                    throw new ApplicationException();

                foreach (FilterInfo device in videoDevices)
                {
                    tscbxCameras.Items.Add(device.Name);
                }

                tscbxCameras.SelectedIndex = 0;

            }
            catch (ApplicationException)
            {
                tscbxCameras.Items.Add("No local capture devices");
                videoDevices = null;
            }
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            CameraConn();
           
        }
        //连接摄像头
        private void CameraConn()
        {
            VideoCaptureDevice videoSource = new VideoCaptureDevice(videoDevices[tscbxCameras.SelectedIndex].MonikerString);
            videoSource.DesiredFrameSize = new System.Drawing.Size(320, 240);
            videoSource.DesiredFrameRate = 1;

            videoSourcePlayer.VideoSource = videoSource;
            videoSourcePlayer.Start();
        }

        //关闭摄像头
        private void btnClose_Click(object sender, EventArgs e)
        {
            videoSourcePlayer.SignalToStop();
            videoSourcePlayer.WaitForStop();
        }

        //主窗体关闭
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            btnClose_Click(null, null);
        }

        //拍照
        private void Photograph_Click(object sender, EventArgs e)
        {
        	
            try
            {
                if (videoSourcePlayer.IsRunning)
                {
                    BitmapSource bitmapSource = System.Windows.Interop.Imaging.CreateBitmapSourceFromHBitmap(
                                    videoSourcePlayer.GetCurrentVideoFrame().GetHbitmap(),
                                    IntPtr.Zero,
                                     Int32Rect.Empty,
                                    BitmapSizeOptions.FromEmptyOptions());
                    PngBitmapEncoder pE = new PngBitmapEncoder();
                    pE.Frames.Add(BitmapFrame.Create(bitmapSource));
                    string picName = GetImagePath() + "\\" + "xiaosy" + ".jpg";
                    if (File.Exists(picName))
                    {
                        File.Delete(picName);
                    }
                    using (Stream stream = File.Create(picName))
                    {
                        pE.Save(stream);
                    }
                    //拍照完成后关摄像头并刷新同时关窗体
                    if (videoSourcePlayer != null && videoSourcePlayer.IsRunning)
                    {
                        videoSourcePlayer.SignalToStop();
                        videoSourcePlayer.WaitForStop();
                    }
                    
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("摄像头异常：" + ex.Message);
            }
        }

        private string GetImagePath()
        {
            string personImgPath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory)
                         + Path.DirectorySeparatorChar.ToString() + "PersonImg";
            if (!Directory.Exists(personImgPath))
            {
                Directory.CreateDirectory(personImgPath);
            }

            return personImgPath;
        }
        
      [DllImport("user32.dll")] 
		public static extern bool ReleaseCapture(); 
		
		[DllImport("user32.dll")] 
		public static extern bool SendMessage(IntPtr hwnd, int wMsg, int wParam, int lParam); 
		  
        void Form1MouseDown(object sender, MouseEventArgs e)
        {
        	ReleaseCapture(); 
			SendMessage(this.Handle, 0x0112, 0xF012, 0); 
        }
        private System.Drawing.Point mouse_offset;
        void VideoSourcePlayerMouseDown(object sender, MouseEventArgs e)
        {
        	mouse_offset = new System.Drawing.Point(-e.X, -e.Y);//
        }
        
        void Form1MouseMove(object sender, MouseEventArgs e)
        {
        	((Control)sender).Cursor = Cursors.Arrow;//设置拖动时鼠标箭头
			if (e.Button == MouseButtons.Left)
			{
			System.Drawing.Point mousePos = Control.MousePosition;
			mousePos.Offset(mouse_offset.X, mouse_offset.Y);//设置偏移
			((Control)sender).Location = ((Control)sender).Parent.PointToClient(mousePos);
			}
        }
        
 
        
        void VideoSourcePlayerDoubleClick(object sender, EventArgs e)
        {
        	MessageBox.Show("大贲科技（上海）研究院专用");
        	if(this.label1.Visible==true){
        		//MessageBox.Show("大贲科技（上海）研究院专用");
	        	this.FormBorderStyle = FormBorderStyle.SizableToolWindow;
	        	this.label1.Visible=false;
	        	this.btnClose.Visible=false;
	        	this.btnConnect.Visible=false;
	        	this.Photograph.Visible=false;
	        	this.tscbxCameras.Visible=false;
	        	this.comboBox1.Visible=false;
	        	//this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.Fill;
        	}else{
	        	//this.FormBorderStyle = FormBorderStyle;
	        	this.FormBorderStyle = FormBorderStyle.None;
	        	this.label1.Visible=true;
	        	this.btnClose.Visible=true;
	        	this.btnConnect.Visible=true;
	        	this.Photograph.Visible=true;
	        	this.tscbxCameras.Visible=true;
	        	this.comboBox1.Visible=true;
	        	//this.videoSourcePlayer.Dock = System.Windows.Forms.DockStyle.None;
        	}
        	
        }
        
      
        int i=1;
        void ComboBox1TextChanged(object sender, EventArgs e)
        {
        	if (i==1){
        		this.videoSourcePlayer.Size = new System.Drawing.Size(317, 237);
        	}else if (i==2){
        		this.videoSourcePlayer.Size = new System.Drawing.Size(600, 450);
        	}else if (i==3){
        		this.videoSourcePlayer.Size = new System.Drawing.Size(400, 300);
        	}else{
        		i=0;
        		this.videoSourcePlayer.Size = new System.Drawing.Size(600, 450);
        	}
        		
        	i=i+1;
        	
        	//MessageBox.Show("ss");
        }
    }
}
