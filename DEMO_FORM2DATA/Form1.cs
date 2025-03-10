using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace DEMO_FORM2DATA
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        #region 전역변수 설정 영역

        #endregion

        #region 생성자및초기화
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            InitControls();
            InitGrid();
            InitEvents();
        }
        
        /// <summary>
        /// 컨트롤 초기화
        /// </summary>
        private void InitControls() 
        { 
            // 컨트롤 초기화 및 데이터 바인딩(그리드 제외)



            // 그리드 초기화(datasource == null)
        
        }
        
        /// <summary>
        /// 그리드 데이터 바인딩
        /// </summary>
        private void InitGrid() 
        {
            GrdMain.DataSource = clsUtil.GridDt001();
        }
        
        /// <summary>
        /// 이벤트 설정
        /// </summary>
        private void InitEvents() 
        {
            BtnQuery.Click += BtnQuery_Click;
        }

        private void BtnQuery_Click(object sender, EventArgs e)
        {
            MessageBox.Show("참쉽죠");
        }
        
        #endregion
        //this.BtnQuery.Click += new System.EventHandler(this.BtnQuery_Click);
        //private void BtnQuery_Click(object sender, EventArgs e)
        //{ 

        //}
    }
}
