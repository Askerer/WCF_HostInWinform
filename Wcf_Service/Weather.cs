using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Windows.Forms;

namespace Wcf_Service
{
	// 注意: 您可以使用 [重構] 功能表上的 [重新命名] 命令同時變更程式碼和組態檔中的類別名稱 "Service1"。
	public class Weather : IWeather
	{
		public string GetData(int value)
		{
			return string.Format("You entered: {0}", value);
		}

		public Bitmap GetBitmap(string sName)
		{
			Bitmap bmp = new Bitmap( Image.FromFile(Application.StartupPath + "\\" + sName + ".bmp"));

			return bmp;

		}


		public CompositeType GetDataUsingDataContract(CompositeType composite)
		{
			if (composite == null)
			{
				throw new ArgumentNullException("composite");
			}
			if (composite.BoolValue)
			{
				composite.StringValue += "Suffix";
			}
			return composite;
		}
	}
}
