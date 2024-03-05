using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectCuoiKhoaCS0523
{
	public class VaiTro
	{
		public VaiTro(string tenVaiTro,string moTa) 
		{
			this.MaVaiTro = tenVaiTro;
			this.MoTa = moTa;
		}
		
		public string MaVaiTro { get; set; }
		public string TenVaiTro { get; set; }
		public string MoTa { get; set; }
	}
}
