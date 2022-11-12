using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    class materials
    {
        public int id { get; set; }

        private string in_wallpapers_width, wallpapers_length_m, wallpapers_amount, wallpapers_circle;
        private string plaster_thick, plaster_volume_m, plaster_kg;
        private string grunt_layers, grunt_volume_m, grunt_kg;
        private string ground_coat_thick, ground_coat_volume_m, ground_coat_volume_kg;
        private string paint_layers, paint_volume_m;
        private string in_plaster_kg_mesh, in_plaster_m_mesh, plaster_amount, in_grunt_kg_mesh, in_grunt_m_mesh, grunt_amount;
        private string in_plaster_thick, in_wallpapers_circle_length, in_ground_coat_kg_mesh, in_ground_coat_m_mesh, ground_coat_amount, in_paint_kg_mesh, in_paint_m_mesh, paint_kg, paint_amount;
        private string in_grunt_layers, in_ground_coat_thick, in_paint_layers;
        private string user_id;
        public string User_id
        {
            get { return user_id; }
            set { user_id = value; }
        }
        public string In_wallpapers_width
        {
            get { return in_wallpapers_width; }
            set { in_wallpapers_width = value; }
        }
        public string In_wallpapers_circle_length
        {
            get { return in_wallpapers_circle_length; }
            set { in_wallpapers_circle_length = value; }
        }
        
        public string Wallpapers_length_m
        {
            get { return wallpapers_length_m; }
            set { wallpapers_length_m = value; }
        }
        public string Wallpapers_amount
        {
            get { return wallpapers_amount; }
            set { wallpapers_amount = value; }
        }
        public string In_plaster_thick
        {
            get { return in_plaster_thick; }
            set { in_plaster_thick = value; }
        }
        
        public string In_plaster_kg_mesh
        {
            get { return in_plaster_kg_mesh; }
            set { in_plaster_kg_mesh = value; }
        }
        
        public string In_plaster_m_mesh
        {
            get { return in_plaster_m_mesh; }
            set { in_plaster_m_mesh = value; }
        }
        
        public string Plaster_volume_m
        {
            get { return plaster_volume_m; }
            set { plaster_volume_m = value; }
        }
        public string Plaster_kg
        {
            get { return plaster_kg; }
            set { plaster_kg = value; }
        }
        
        public string Plaster_amount
        {
            get { return plaster_amount; }
            set { plaster_amount = value; }
        }
        
        public string In_grunt_layers
        {
            get { return in_grunt_layers; }
            set { in_grunt_layers = value; }
        }
        
        public string In_grunt_kg_mesh
        {
            get { return in_grunt_kg_mesh; }
            set { in_grunt_kg_mesh = value; }
        }
        public string In_grunt_m_mesh
        { 
            get { return in_grunt_m_mesh; }
            set { in_grunt_m_mesh = value; }
        }
        public string Grunt_volume_m
        {
            get { return grunt_volume_m; }
            set { grunt_volume_m = value; }
        }
        
            public string Grunt_kg
        {
            get { return grunt_kg; }
            set { grunt_kg = value; }
        }
        
        public string Grunt_amount
        {
            get { return grunt_amount; }
            set { grunt_amount = value; }
        }
        public string In_ground_coat_thick
        {
            get { return in_ground_coat_thick; }
            set { in_ground_coat_thick = value; }
        }
        public string In_ground_coat_kg_mesh
        {
            get { return in_ground_coat_kg_mesh; }
            set { in_ground_coat_kg_mesh = value; }
        }
        public string In_ground_coat_m_mesh
        {
            get { return in_ground_coat_m_mesh; }
            set { in_ground_coat_m_mesh = value; }
        }
        public string Ground_coat_volume_m
        {
            get { return ground_coat_volume_m; }
            set { ground_coat_volume_m = value; }
        }
        public string Ground_coat_volume_kg
        {
            get { return ground_coat_volume_kg; }
            set { ground_coat_volume_kg = value; }
        }
        
        public string Ground_coat_amount
        {
            get { return ground_coat_amount; }
            set { ground_coat_amount = value; }
        }
        public string In_paint_layers
        {
            get { return in_paint_layers; }
            set { in_paint_layers = value; }
        }
        public string In_paint_kg_mesh
        {
            get { return in_paint_kg_mesh; }
            set { in_paint_kg_mesh = value; }
        }
        
        public string In_paint_m_mesh
        {
            get { return in_paint_m_mesh; }
            set { in_paint_m_mesh = value; }
        }
        public string Paint_volume_m
        {
            get { return paint_volume_m; }
            set { paint_volume_m = value; }
        }
        
         public string Paint_kg
        {
            get { return paint_kg; }
            set { paint_kg = value; }
        }
        public string Paint_amount
        {
            get { return paint_amount; }
            set { paint_amount = value; }
        }
        


        public materials() { }
        public materials(string user_id, string in_wallpapers_width, string in_wallpapers_circle_length, string wallpapers_length_m, string wallpapers_amount, string in_plaster_thick, string in_plaster_kg_mesh, string in_plaster_m_mesh, string plaster_volume_m, string plaster_kg, string plaster_amount, string in_grunt_layers, string in_grunt_kg_mesh, string in_grunt_m_mesh, string grunt_volume_m, string grunt_kg, string grunt_amount, string in_ground_coat_thick, string in_ground_coat_kg_mesh, string in_ground_coat_m_mesh, string ground_coat_volume_m, string ground_coat_volume_kg, string ground_coat_amount, string in_paint_layers, string in_paint_kg_mesh, string in_paint_m_mesh, string paint_volume_m, string paint_kg, string paint_amount) {
            /* this.in_wallpapers_width = in_wallpapers_width;
             this.wallpapers_length_m = wallpapers_length_m;
             this.wallpapers_amount = wallpapers_amount;
             this.wallpapers_circle = wallpapers_circle;

             this.plaster_thick = plaster_thick;
             this.plaster_volume_m = plaster_volume_m;
             this.plaster_kg = plaster_kg;

             this.grunt_layers = grunt_layers;
             this.grunt_volume_m = grunt_volume_m;
             this.grunt_kg = grunt_kg;

             this.ground_coat_thick = ground_coat_thick;
             this.ground_coat_volume_m = ground_coat_volume_m;
             this.ground_coat_volume_kg = ground_coat_volume_kg;

             this.paint_layers = paint_layers;
             this.paint_volume_m = paint_volume_m;*/
            this.user_id = user_id;

            this.in_wallpapers_width = in_wallpapers_width;
            this.in_wallpapers_circle_length = in_wallpapers_circle_length;
            this.wallpapers_length_m = wallpapers_length_m;
            this.wallpapers_amount = wallpapers_amount;

            this.in_plaster_thick = in_plaster_thick;
            this.in_plaster_kg_mesh = in_plaster_kg_mesh;
            this.in_plaster_m_mesh = in_plaster_m_mesh;
            this.plaster_volume_m = plaster_volume_m;
            this.plaster_kg = plaster_kg;
            this.plaster_amount = plaster_amount;

            this.in_grunt_layers = in_grunt_layers;
            this.in_grunt_kg_mesh = in_grunt_kg_mesh;
            this.in_grunt_m_mesh = in_grunt_m_mesh;
            this.grunt_volume_m = grunt_volume_m;
            this.grunt_kg = grunt_kg;
            this.grunt_amount = grunt_amount;

            this.in_ground_coat_thick = in_ground_coat_thick;
            this.in_ground_coat_kg_mesh = in_ground_coat_kg_mesh;
            this.in_ground_coat_m_mesh = in_ground_coat_m_mesh;
            this.ground_coat_volume_m = ground_coat_volume_m;
            this.ground_coat_volume_kg = ground_coat_volume_kg;
            this.ground_coat_amount = ground_coat_amount;

            this.in_paint_layers = in_paint_layers;
            this.in_paint_kg_mesh = in_paint_kg_mesh;
            this.in_paint_m_mesh = in_paint_m_mesh;
            this.paint_volume_m = paint_volume_m;
            this.paint_kg = paint_kg;
            this.paint_amount = paint_amount;

        }

    }
}
