using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_3_Operators
{
    public partial class Practice
    {
        /// <summary>
        /// B3-P1/5. NumbersAddition. Напишите алгоритм, который складывает два числа.
        /// </summary>
		
		public static double SUM2Number()
		{	
			double x, y;
			Console.WriteLine("Введите число 1");
			x = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите число 2");
			y = double.Parse(Console.ReadLine());
			return x + y;
		}
		
			public static double SUM2NumberWithOper()
		{	
			double x, y;
			Console.WriteLine("Введите число 1");
			x = double.Parse(Console.ReadLine());
			Console.WriteLine("Введите число 2");
			y = double.Parse(Console.ReadLine());
			
			int i = 0;
						
			while( i < 3)
			{
				Console.WriteLine("Введите + или - \n");
				string oper = Console.ReadLine();
				if(oper == "+") return x + y;
				if(oper == "-") return x - y;
				else Console.WriteLine("Ошибка!!!");
				i++;
			}
                Console.WriteLine("Алгоритм прекращен");
                return 0.0;
		}
		
        public static void B3_P1_9_NumbersAddition()
        {
			double sum;
			sum = SUM2Number();
			Console.WriteLine("Ответ\n" + sum);
        }

        /// <summary>
        /// B3-P2/9. CheckResultAddition. Изменить предыдущий алгоритм. 
        /// Пускай он теперь не выводит ответ сам. 
        /// А запрашивает ответ и потом проверяет его на правильность.
        /// </summary>
        public static void B3_P2_9_CheckResultAddition()
        {
			double sum;
			double answer;
			
			sum = SUM2Number();
			
			Console.WriteLine("Введите ответ");
			answer = double.Parse(Console.ReadLine());
			
			if(sum == answer) Console.WriteLine("Правильно\n");
			else Console.WriteLine("Неправильно\n");
			
        }

        /// <summary>
        /// B3-P3/9. CheckResultAdditionWithTips. Изменить предыдущий алгоритм. 
        /// Пускай он теперь выводит не только информацию правильно или не правильно, 
        /// но и дополнительно, 	ожидается число больше или меньше указанного.
        /// </summary>
        public static void B3_P3_9_CheckResultAdditionWithTips()
        {
			bool Less;
			double sum;
			double answer;
			
			sum = SUM2Number();
			
			Console.WriteLine("Введите ответ");
			answer = double.Parse(Console.ReadLine());
			
			if(sum == answer) Console.WriteLine("Правильно\n");
			else 
			{
				Console.WriteLine("Неправильно\n");

                Less = sum > answer ? true : false;   
      
                if (Less == true) Console.WriteLine("Число должно быть больше\n");
                else Console.WriteLine("Число должно быть меньше\n");
			}
        }

        /// <summary>
        /// B3-P4/9. CheckResultWithOperator. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм теперь запрашивает оператор (+ или -).
        /// </summary>
        public static void B3_P4_9_CheckResultWithOperator()
        {
			bool Less;
			double sum;
            double answer;
			sum = SUM2NumberWithOper();
			
			Console.WriteLine("Введите ответ");
			answer = double.Parse(Console.ReadLine());
			
			if(sum == answer) Console.WriteLine("Правильно\n");
			else 
			{
				Console.WriteLine("Неправильно\n");
				
                Less = sum > answer ? true : false;

                if (Less == true) Console.WriteLine("Число должно быть больше\n");
                else Console.WriteLine("Число должно быть меньше\n");
			}
        }

			
        

        /// <summary>
        /// B3-P5/9. CheckResultWithAttemps. Изменить предыдущий алгоритм. 
        /// Пускай у пользователя будет 3 попытки чтобы решить эту задачу правильно
        /// </summary>
        public static void B3_P5_9_CheckResultWithAttemps()
        {
            int i = 3;
			bool Less = true;
            bool flg = true;
			double sum;
            double answer;
			sum = SUM2NumberWithOper();
			
			Console.WriteLine("Введите ответ/n");
			answer = double.Parse(Console.ReadLine());

            while (i > 0)
            {
                if (flg == false)
                {
                    Console.WriteLine("Осталось   " + (i) + "   попыток. Введите ответ еще раз/n");
                    answer = double.Parse(Console.ReadLine());
                }
                if (sum == answer)
                {
                    Console.WriteLine("Правильно/n");
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильно/n");
                    Less = sum > answer ? true : false;

                    if (Less == true) Console.WriteLine("Число должно быть больше\n");
                    else Console.WriteLine("Число должно быть меньше\n");

                    flg = false;
                }
                i--;
            }



        }

        /// <summary>
        /// B3-P6/9. FiveNumbersAddition. Изменить предыдущий алгоритм. 
        /// Пускай алгоритм складывает пять чисел вместо двух.
        /// </summary>
        public static void B3_P6_9_FiveNumbersAddition()
        {
            int i = 3;
            bool flg = true;
            bool Less = true;
			double sum = 0;
			double x;
            double answer;

			for(int j = 0; j < 5; j++)
			{
				Console.WriteLine("Введите число  " + (j+1) + "\n");
				x = double.Parse(Console.ReadLine());
				sum+=x;
			}
			
			Console.WriteLine("Введите ответ/n");
			answer = double.Parse(Console.ReadLine());

            while (i > 0)
            {
                if (flg == false)
                {
                    Console.WriteLine("Осталось   " + (i) + "   попыток. Введите ответ еще раз/n");
                    answer = double.Parse(Console.ReadLine());
                }
                if (sum == answer)
                {
                    Console.WriteLine("Правильно/n");
                    break;
                }
                else
                {
                    Console.WriteLine("Неправильно/n");
                    Less = sum > answer ? true : false;

                    if (Less == true) Console.WriteLine("Число должно быть больше\n");
                    else Console.WriteLine("Число должно быть меньше\n");

                    flg = false;
                }
                i--;
            }
			
        }

        /// <summary>
        /// B3-P7/9. NumbersResultWithInfoIfCorrect. Изменить предыдущий алгоритм. 
        /// В конце алгоритма выводить информацию была ли задача решена правильно.
        /// </summary>
        public static void B3_P7_9_NumbersResultWithInfoIfCorrect()
        {
            int i = 3;
            bool flg = true;
            bool Less = true;
            bool TrueAns = true;
            double sum = 0;
            double x;
            double answer, answ2, answ3;

            answ2 = answ3 = 0;

            for (int j = 0; j < 5; j++)
            {
                Console.WriteLine("Введите число  " + (j + 1) + "\n");
                x = double.Parse(Console.ReadLine());
                sum += x;
            }

            Console.WriteLine("Введите ответ");
            answer = double.Parse(Console.ReadLine());

            if (sum == answer)
            {
                Console.WriteLine("Правильно/n");
            }
            else
            { 
                Console.WriteLine("Неправильно/n");
                Less = sum > answer ? true : false;
                if (Less == true) Console.WriteLine("Число должно быть больше\n");
                else Console.WriteLine("Число должно быть меньше\n");

                Console.WriteLine("Введите ответ еще 2 раза");
                 answ2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите ответ еще раз");
                 answ3 = double.Parse(Console.ReadLine());
            }

            if(sum == answ2 || sum == answ3)
                Console.WriteLine("Задача была решена правильно\n");


            //while (i > 0)
            //{
            //    if (flg == false)
            //    {
            //        Console.WriteLine("Осталось   " + (i) + "   попыток. Введите ответ еще раз/n");
            //        answer = double.Parse(Console.ReadLine());
            //    }
            //    if (sum == answer  && flg == true)
            //    {
            //        Console.WriteLine("Правильно/n");
            //        break;
            //    }
            //    else
            //    {
            //        if (flg == true)
            //        {
            //            Console.WriteLine("Неправильно/n");
            //            Less = sum > answer ? true : false;

            //            if (Less == true) Console.WriteLine("Число должно быть больше\n");
            //            else Console.WriteLine("Число должно быть меньше\n");
            //        }
            //        flg = false;

            //        TrueAns = sum == answer ? true : false;
            //    }
            //    i--;
            //}

            //if (TrueAns == true) Console.WriteLine("Задача решилась правильно\n");
            //else Console.WriteLine("Задача решилась неправильно\n");

            // условие у задачи странное "Вывод правильно ли решилась задача", пришлось искуственно использовать логический оператор.
			
        }

        /// <summary>
        /// B3-P8/9. CircleArea. Написать алгоритм, рассчитывающий площадь круга по заданному радиусу. 
        /// </summary>
        public static void B3_P8_9_CircleArea()
        {
			// S = pi*r^2
            double S, r;
            const double Pi = 3.14;

            Console.WriteLine("Введите радиус");
            r = double.Parse(Console.ReadLine());

            S = Pi * r * r;

            Console.WriteLine("Площадь круга = " + S);
        }

        /// <summary>
        /// B3-P9/9. CreaditCalculator.Написать программу - калькулятор кредита на 1 год.
        /// </summary>
        public static void B3_P9_9_CreaditCalculator()
        {
            decimal Sum = 0;
            double Plata = 0;
            double Credit, Proc, FixStav;
            

            Console.WriteLine("Введите сумму кредита");
            Credit = double.Parse(Console.ReadLine());

            Console.WriteLine("Введите процентную ставку");
                
            Proc = double.Parse(Console.ReadLine());

            for (int i = 0; i < 3; i++)
            {
                if (Proc > 100 || Proc < 0)
                {
                    Console.WriteLine("Проценты не могут быть меньше 0 или более 100\n");

                    Console.WriteLine("Введите процентную ставку");

                    Proc = double.Parse(Console.ReadLine());
                }
                else break;
            }

            List<int> mons = new List<int> { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

            FixStav = Credit / 12; // 1 год из условия

            for (int i = 0; i < 12; i++)
            {
                Plata = Convert.ToDouble(Credit*(Proc * mons[i] / (100 * 365)));
                Sum += Convert.ToDecimal(Plata + FixStav);
                Credit -= FixStav;
                Console.WriteLine( "Выплата за " + (i+1) + " месяц : " + "{0:0.00}", Plata); // у нас копейки
            }

            Console.WriteLine("Общая сумма выплат составит : " + "{0:0.00}", Sum);
            
				//СНП=(ООЗ×ПС×КДМ)/(100×365),

				//где сумма начисляемых процентов (СНП) равна частному чисел, получаемых при произведении остатка основного займа (ООЗ), процентной ставки (ПС), количества дней в выбранном месяце (КДМ) и произведении ста процентов и количества дней в году (365 либо 366).

				//Поскольку сумма основной задолженности будет постоянно уменьшаться на размер выплаченной ранее базовой части кредита, ежемесячно также будет уменьшаться и сумма начисляемых банком процентов.

				//Например, клиенту предоставлен кредит 48 000 рублей на один год с дифференцированной системой погашения долга под 10% годовых. Фиксированная сумма погашения основной массы кредита составит 4 000 рублей (48 000/12=4000). При этом ежемесячно тело кредита будет уменьшаться ровно на 4 000.

				//В первый месяц платеж клиента составит – 4 000 (погашение тела кредита) + 407,67 (48 000*10*31/100*365)=4 407,67. Во второй месяц – 4 000 + 361,64 (44 000*10*30/100*365) = 4 361,64. Третий месяц – 4 000 +339,73 (40 000*10*31/100*365) 4 339,73 и так далее.
        }
    }
}
