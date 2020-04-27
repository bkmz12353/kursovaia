
using System;

using System.Collections.Generic;

using System.ComponentModel;

using System.Data;

using System.Drawing;

using System.Text;

using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {

        private Area LivingArea;   //Место обитания

        public Form1()

        {
            InitializeComponent();
        }

        private void showData()

        {
            lbHerbirove.Text = LivingArea.herbivore.count.ToString();

            lbPlants.Text = LivingArea.plant.count.ToString();

            lbPredators.Text = LivingArea.predator.count.ToString();

        }



       

        

        private void button1_Click(object sender, EventArgs e)
        {

            LivingArea = new Area();

            LivingArea.availabalArea = 10000;    //Величина места обитания


            LivingArea.herbivore = new Herbivore();        //Обьект травоядных 

            LivingArea.herbivore.count = Convert.ToInt32(planteaterdata.Text);  //Количество травоядных

            LivingArea.herbivore.foodNeed = 2;      //коэффициент необходимой еды для травоядных

            LivingArea.herbivore.growthSpeed = Convert.ToDouble(planteaterborn.Text.Replace('.', ','));   //коэффициент рождаемости для травоядных



            LivingArea.plant = new Plant();    //Обьект растений

            LivingArea.plant.count = Convert.ToInt32(plantdata.Text);    //Количество растений

            LivingArea.plant.countOnAreaUnit = 10; //предел количества растений к площади

            LivingArea.plant.growthSpeed = Convert.ToDouble(plantborn.Text.Replace('.', ','));   //коэффициент роста растений



            LivingArea.predator = new Predator();     //Обьект хищников

            LivingArea.predator.count = Convert.ToInt32(predatordata.Text); //Количество хищников

            LivingArea.predator.foodNeed = 1;    //коэффициент необходимой еды для хищников
            
            LivingArea.predator.growthSpeed = Convert.ToDouble (predatorborn.Text.Replace('.',',')); //коэффициент рождаемости для хищников


            
            int cn =Convert.ToInt32(timedata.Text);   //количество итерраций расчета


            chart1.Series.Clear();

            chart1.Series.Add("Травоядные");

            chart1.Series.Add("Растения");

            chart1.Series.Add("Хищники");

            chart1.Series[0].ChartType = SeriesChartType.Line;

            chart1.Series[0].BorderWidth = 3;

            chart1.Series[1].ChartType = SeriesChartType.Line;

            chart1.Series[1].BorderWidth = 3;

            chart1.Series[2].ChartType = SeriesChartType.Line;

            chart1.Series[2].BorderWidth = 3;

            
            for (int i = 1; i <= cn; i++) // отрисовка графика
            {
                chart1.Series[0].Points.AddXY(i, LivingArea.herbivore.count);

                chart1.Series[1].Points.AddXY(i, LivingArea.plant.count);

                chart1.Series[2].Points.AddXY(i, LivingArea.predator.count);

                LivingArea.liveLoop();

            }

            LivingArea.liveLoop();

            showData();  // отображение итоговых значений
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel_Click(object sender, EventArgs e)
        {

        }
    }
    public abstract class BaseClass
    {
        private BaseClass _owner;
        public BaseClass owner
        {
            get  { return _owner; }
             
            set { _owner = value; }
        }
        public abstract string GetClassCaption();

    }
    public class Plant : BaseClass
    {
        public override string GetClassCaption()

        {
            return "Растение";
        }
        private double _countOnAreaUnit;

        public double countOnAreaUnit
        {
            get { return _countOnAreaUnit; }
            set { _countOnAreaUnit = value; }
        }

        private double _growthSpeed;

        public double growthSpeed
        {
            get { return _growthSpeed; }
            set { _growthSpeed = value; }
        }

        private double _count;

        public double count
        {
            get { return _count; }
            set { _count = value; }
        }

        public void grow(double availabalArea)

        {

            double totalCount = _count + _growthSpeed;

            double totalArea = totalCount / _countOnAreaUnit;

            if (totalArea > availabalArea) totalArea = availabalArea;

            _count = totalArea * _countOnAreaUnit;

        }

    }
    public class Herbivore
    {
        public virtual string GetClassCaption()
        {
            return "Травоядное животное";
        }
        private double _foodNeed;

        public double foodNeed
        {
            get
            {
                return _foodNeed;
            }
            set
            {
                _foodNeed = value;
            }
        }
        private double _growthSpeed;

        public double growthSpeed
        {
            get
            {
                return _growthSpeed;
            }
            set
            {
                _growthSpeed = value;
            }
        }
        private int _count;

        public int count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public void liveLoop(Plant plant)
        {
            double availabalFood = plant.count;

            double needFood = _count * _foodNeed;

            if (needFood > availabalFood)

            {

                //если еды не хватает,

                //то некоторые живтоные умирают

                int animalIsFull = Convert.ToInt32(availabalFood / _foodNeed); // скольки животным хватит еды

                _count = animalIsFull; //выживает только те, кто успел "пообедать"



                //все растения съедены

                plant.count = 0;

            }

            else

            {

                //еды хватило всем, животные размножаються

                _count = Convert.ToInt32(_count * (1 + _growthSpeed));



                //животные съели растения, отразим этот факт - уменьшим кол-во растений

                plant.count = plant.count - needFood;

            }



        }

    }
    public class Predator
    {
        public virtual string GetClassCaption()
        {
            return "Хищник";
        }
        private int _foodNeed;

        public int foodNeed
        {
            get
            {
                return _foodNeed;
            }
            set
            {
                _foodNeed = value;
            }
        }
        private double _growthSpeed;

        public double growthSpeed
        {
            get
            {
                return _growthSpeed;
            }
            set
            {
                _growthSpeed = value;
            }
        }

        private int _count;

        public int count
        {
            get
            {
                return _count;
            }
            set
            {
                _count = value;
            }
        }

        public void liveLoop(Herbivore herbivore)
        {
            int availabalFood = herbivore.count;

            int needFood = _count * _foodNeed;

            //проверим, хватает ли еды

            if (needFood > availabalFood)

            {

                //если еды не хватает,

                //то некоторые хищники умирают

                int animalIsFull = Convert.ToInt32(availabalFood / _foodNeed); // скольки животным хватит еды

                _count = animalIsFull; //выживает только те, кто успел "пообедать"



                //все жертвы съедены

                herbivore.count = 0;

            }

            else

            {

                //еды хватило всем, хищники размножаются

                _count = Convert.ToInt32(_count * (1 + _growthSpeed));



                //хищники съели травоядных, отразим этот факт - уменьшим кол-во растений

                herbivore.count = herbivore.count - needFood;

            }



        }
    }
    public class Area : BaseClass
    {
        private Plant _plant;
        public override string GetClassCaption()
        {
            return "Площадка";
        }

        public Plant plant
        {
            get
            {
                return _plant;
            }
            set
            {
                _plant = value;
            }
        }
        private Herbivore _herbivore;

        public Herbivore herbivore
        {
            get
            {
                return _herbivore;
            }
            set
            {
                _herbivore = value;
            }
        }

        private Predator _predator;

        public Predator predator
        {
            get
            {
                return _predator;
            }
            set
            {
                _predator = value;
            }
        }
        private double _availabalArea;

        public double availabalArea
        {
            get
            {
                return _availabalArea;
            }
            set
            {
                _availabalArea = value;
            }
        }

        public void liveLoop()
        {
            _plant.grow(_availabalArea);

            _herbivore.liveLoop(_plant);

            _predator.liveLoop(_herbivore);

        }

    }
}

