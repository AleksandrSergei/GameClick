using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра
{
    public class Model
    {
        public int[] number_clicks;
        public string[] label_names;
        public string[] path_names;
        public string[] tasks;
        public int[,] number_button;
        public int sec = 0;
        public int level = 1;
        public int complexity;
        public int count_levels;
        public int[] time_sec;
        public int[,] number_random_clicks;
    }
}
