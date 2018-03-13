namespace OperateCamera
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
        	this.Photograph = new System.Windows.Forms.Button();
        	this.btnClose = new System.Windows.Forms.Button();
        	this.tscbxCameras = new System.Windows.Forms.ComboBox();
        	this.btnConnect = new System.Windows.Forms.Button();
        	this.label1 = new System.Windows.Forms.Label();
        	this.videoSourcePlayer = new AForge.Controls.VideoSourcePlayer();
        	this.textBox1 = new System.Windows.Forms.TextBox();
        	this.comboBox1 = new System.Windows.Forms.ComboBox();
        	this.label2 = new System.Windows.Forms.Label();
        	this.label3 = new System.Windows.Forms.Label();
        	this.SuspendLayout();
        	// 
        	// Photograph
        	// 
        	this.Photograph.Location = new System.Drawing.Point(395, 166);
        	this.Photograph.Name = "Photograph";
        	this.Photograph.Size = new System.Drawing.Size(75, 23);
        	this.Photograph.TabIndex = 1;
        	this.Photograph.Text = "退出";
        	this.Photograph.UseVisualStyleBackColor = true;
        	this.Photograph.Click += new System.EventHandler(this.Photograph_Click);
        	// 
        	// btnClose
        	// 
        	this.btnClose.Location = new System.Drawing.Point(395, 137);
        	this.btnClose.Name = "btnClose";
        	this.btnClose.Size = new System.Drawing.Size(75, 23);
        	this.btnClose.TabIndex = 3;
        	this.btnClose.Text = "关闭";
        	this.btnClose.UseVisualStyleBackColor = true;
        	this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
        	// 
        	// tscbxCameras
        	// 
        	this.tscbxCameras.FormattingEnabled = true;
        	this.tscbxCameras.Location = new System.Drawing.Point(395, 24);
        	this.tscbxCameras.Name = "tscbxCameras";
        	this.tscbxCameras.Size = new System.Drawing.Size(75, 20);
        	this.tscbxCameras.TabIndex = 7;
        	// 
        	// btnConnect
        	// 
        	this.btnConnect.Location = new System.Drawing.Point(395, 108);
        	this.btnConnect.Name = "btnConnect";
        	this.btnConnect.Size = new System.Drawing.Size(75, 23);
        	this.btnConnect.TabIndex = 8;
        	this.btnConnect.Text = "连接";
        	this.btnConnect.UseVisualStyleBackColor = true;
        	this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
        	// 
        	// label1
        	// 
        	this.label1.AutoSize = true;
        	this.label1.Location = new System.Drawing.Point(395, 9);
        	this.label1.Name = "label1";
        	this.label1.Size = new System.Drawing.Size(89, 12);
        	this.label1.TabIndex = 9;
        	this.label1.Text = "视频输入设备：";
        	// 
        	// videoSourcePlayer
        	// 
        	this.videoSourcePlayer.AllowDrop = true;
        	this.videoSourcePlayer.Location = new System.Drawing.Point(-11, 0);
        	this.videoSourcePlayer.Name = "videoSourcePlayer";
        	this.videoSourcePlayer.Size = new System.Drawing.Size(400, 300);
        	this.videoSourcePlayer.TabIndex = 10;
        	this.videoSourcePlayer.Text = "videoSourcePlayer";
        	this.videoSourcePlayer.VideoSource = null;
        	this.videoSourcePlayer.DoubleClick += new System.EventHandler(this.VideoSourcePlayerDoubleClick);
        	this.videoSourcePlayer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.VideoSourcePlayerMouseDown);
        	// 
        	// textBox1
        	// 
        	this.textBox1.Font = new System.Drawing.Font("楷体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
        	this.textBox1.Location = new System.Drawing.Point(0, 0);
        	this.textBox1.Multiline = true;
        	this.textBox1.Name = "textBox1";
        	this.textBox1.Size = new System.Drawing.Size(317, 31);
        	this.textBox1.TabIndex = 11;
        	this.textBox1.Text = "主讲：张奇，电话:15889723562";
        	// 
        	// comboBox1
        	// 
        	this.comboBox1.FormattingEnabled = true;
        	this.comboBox1.Items.AddRange(new object[] {
        	        	        	"切换1",
        	        	        	"切换2",
        	        	        	"切换3"});
        	this.comboBox1.Location = new System.Drawing.Point(396, 73);
        	this.comboBox1.Name = "comboBox1";
        	this.comboBox1.Size = new System.Drawing.Size(75, 20);
        	this.comboBox1.TabIndex = 12;
        	this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1SelectedIndexChanged);
        	this.comboBox1.TextChanged += new System.EventHandler(this.ComboBox1TextChanged);
        	// 
        	// label2
        	// 
        	this.label2.Location = new System.Drawing.Point(396, 196);
        	this.label2.Name = "label2";
        	this.label2.Size = new System.Drawing.Size(74, 72);
        	this.label2.TabIndex = 13;
        	this.label2.Text = "点连接开始，双击左侧视频框可以显示和隐藏工具栏";
        	// 
        	// label3
        	// 
        	this.label3.Location = new System.Drawing.Point(396, 47);
        	this.label3.Name = "label3";
        	this.label3.Size = new System.Drawing.Size(100, 23);
        	this.label3.TabIndex = 14;
        	this.label3.Text = "切换尺寸：";
        	// 
        	// Form1
        	// 
        	this.AllowDrop = true;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(473, 302);
        	this.Controls.Add(this.label3);
        	this.Controls.Add(this.label2);
        	this.Controls.Add(this.comboBox1);
        	this.Controls.Add(this.textBox1);
        	this.Controls.Add(this.videoSourcePlayer);
        	this.Controls.Add(this.label1);
        	this.Controls.Add(this.btnConnect);
        	this.Controls.Add(this.tscbxCameras);
        	this.Controls.Add(this.btnClose);
        	this.Controls.Add(this.Photograph);
        	this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
        	this.Name = "Form1";
        	this.Text = "大贲科技（上海）研究院专用 by QIWEB @ 2018";
        	this.TopMost = true;
        	this.Load += new System.EventHandler(this.Form1_Load);
        	this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1MouseDown);
        	this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
        	this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1MouseMove);
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;

        #endregion

        private System.Windows.Forms.Button Photograph;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox tscbxCameras;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private AForge.Controls.VideoSourcePlayer videoSourcePlayer;
        
        void ComboBox1SelectedIndexChanged(object sender, System.EventArgs e)
        {
        	
        }
    }
}

