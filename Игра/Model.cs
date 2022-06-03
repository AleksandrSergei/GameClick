using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Игра
{
    public class Model
    {
        public int number_institute;
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
        public int[,] coordinate_1 = new int[360, 2];
        public int[,] coordinate_2 = new int[360, 2];
        public int[,] coordinate_3 = new int[360, 2];
        public int index_coordinate1 = 0;
        public int index_coordinate2 = 0;
        public int index_coordinate3 = 0;
    }

    public static class Statistics
    {
        public static int number_clicks = 0;
    }

    public static class Button_image_map
    {
        public static string Image_IMiKN = $"фотки\\иконка ИМиКН.png";
        public static bool Image_IMiKN_Enabled = true;

        public static string Image_IGiP = $"фотки\\иконка ИГиП.png";
        public static bool Image_IGiP_Enabled = true;

        public static string Image_InBio = $"фотки\\иконка ИнБио.png";
        public static bool Image_InBio_Enabled = true;

        public static string Image_InZem = $"фотки\\иконка ИнЗем.png";
        public static bool Image_InZem_Enabled = true;

        public static string Image_IPiP = $"фотки\\иконка ИПиП.png";
        public static bool Image_IPiP_Enabled = true;

        public static string Image_IFK = $"фотки\\иконка ИФК.png";
        public static bool Image_IFK_Enabled = true;

        public static string Image_FizTech = $"фотки\\иконка ФизТех.png";
        public static bool Image_FizTech_Enabled = true;

        public static string Image_FEI = $"фотки\\иконка ФЭИ.png";
        public static bool Image_FEI_Enabled = true;
    }
}
