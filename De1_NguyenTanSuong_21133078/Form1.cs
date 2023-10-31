using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace De1_NguyenTanSuong_21133078
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            using (var context = new WalletDBFirst1DataSet())
            {
                var query = from v in context.Vi
                            join hv in context.Hang on v.MaHang equals hv.MaHang
                            join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                            select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

                dataGridView1.DataSource = query.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var query = from v in context.Vi
                        join hv in context.Hang on v.MaHang equals hv.MaHang
                        join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                        select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

            dataGridView1.DataSource = query.ToList();
            var query = from v in context.Vi
                        join hv in context.Hang on v.MaHang equals hv.MaHang
                        join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                        select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

            dataGridView1.DataSource = query.ToList();
            var query = from v in context.Vi
                        join hv in context.Hang on v.MaHang equals hv.MaHang
                        join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                        select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var query = from v in context.Vi
                        join hv in context.Hang on v.MaHang equals hv.MaHang
                        join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                        select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

            dataGridView1.DataSource = query.ToList();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            var query = from v in context.Vi
                        join hv in context.Hang on v.MaHang equals hv.MaHang
                        join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                        select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

            dataGridView1.DataSource = query.ToList();
        }
        var query = from v in context.Vi
                    join hv in context.Hang on v.MaHang equals hv.MaHang
                    join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                    select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

        dataGridView1.DataSource = query.ToList();
private void button2_Click(object sender, EventArgs e)
        {

        }
    }
    var query = from v in context.Vi
                join hv in context.Hang on v.MaHang equals hv.MaHang
                join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

    dataGridView1.DataSource = query.ToList();
        }
var query = from v in context.Vi
            join hv in context.Hang on v.MaHang equals hv.MaHang
            join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
            select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

dataGridView1.DataSource = query.ToList();
        } var query = from v in context.Vi
                      join hv in context.Hang on v.MaHang equals hv.MaHang
                      join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                      select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

dataGridView1.DataSource = query.ToList();
        } var query = from v in context.Vi
                      join hv in context.Hang on v.MaHang equals hv.MaHang
                      join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                      select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

dataGridView1.DataSource = query.ToList();
        } var query = from v in context.Vi
                      join hv in context.Hang on v.MaHang equals hv.MaHang
                      join lv in context.LoaiVi on v.MaLoai equals lv.MaLoai
                      select new { TenVi = v.TenVi, TenHang = hv.TenHang, MauSac = v.MauSac, Gia = v.Gia, TenLoai = lv.TenLoai };

dataGridView1.DataSource = query.ToList();
        }
}
    }
}
