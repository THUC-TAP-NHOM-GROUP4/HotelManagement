using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManagement.Views
{
    class room_item
    {
        private System.Windows.Forms.Button button1;
        
        public room_item(int height, int width)
        {
            this.button1 = new System.Windows.Forms.Button();
           
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(81, 47);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(161, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "T2-201";
            this.button1.UseVisualStyleBackColor = false;
        }
    }
}
