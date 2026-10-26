using System;

namespace CSLab02
{
    class NotNegativeException : Exception
    {
        public NotNegativeException() : base("Gia tri duoi dau can < 0")
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Nhap so nguyen x: ");
                int x = int.Parse(Console.ReadLine());

                Console.Write("Nhap so nguyen y: ");
                int y = int.Parse(Console.ReadLine());

                int mauSo = 2 * x - y;

                if (mauSo == 0)
                {
                    throw new DivideByZeroException();
                }

                double giaTriDuoiCan = (3.0 * x + 2.0 * y) / mauSo;

                if (giaTriDuoiCan < 0)
                {
                    throw new NotNegativeException();
                }

                double H = Math.Sqrt(giaTriDuoiCan);
                Console.WriteLine($"Gia tri cua bieu thuc H = {H}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Loi: Sai dinh dang (FormatException). Vui long nhap dung so nguyen!");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Loi: Phep chia cho 0 (DivideByZeroException). Dieu kien 2x - y != 0 khong thoa man!");
            }
            catch (NotNegativeException ex)
            {
                Console.WriteLine("Loi: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Loi khong xac dinh: " + ex.Message);
            }

            Console.ReadKey();
        }
    }
}