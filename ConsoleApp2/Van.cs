using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Van
    {
        private  String _Number;
        private  int _Model;
        private  String _Technology;
        private String _Station;
        public static List<Van> vanList = new List<Van>();

        public Van()
        {
            
        }
        public Van(String Number,int Model,String Technology,String Station) 
        {
            this._Number = Number;
            this._Model = Model;
            this._Technology = Technology;
            this._Station = Station;
        
        }

        public String Num
        {
            get { return _Number; }
        }

        public int Model
        {
            get { return _Model; }
        }

        public String Technology
        {
            get { return _Technology; }
        }
        public String Station
        {
            get { return _Station; }
        }
    }
}
