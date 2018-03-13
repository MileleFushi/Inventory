using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory
{
    public class DefaultItemIcon
    {
        private static String ENCODED_DEFAULT_IMAGE = 
			"data:image/png;base64," +
			"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";
	

        public static string _ENCODED_DEFAULT_IMAGE
        {

            get { return ENCODED_DEFAULT_IMAGE; }
        }
    }
}
