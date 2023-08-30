using System;
using System.Collections.Generic;
using System.Text;

namespace bai3
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    namespace bai1
    {
        class Triangle
        {
            private double ma;
            private double mb;
            private double mc;

            // Constructor mặc định
            public Triangle()
            {
                this.ma = 0;
                this.mb = 0;
                this.mc = 0;
            }

            // Constructor đủ tham số
            public Triangle(double ma, double mb, double mc)
            {
                if (ma <= 0 || mb <= 0 || mc <= 0 || !TamGiacHopLe(ma, mb, mc))
                {
                    this.ma = 0;
                    this.mb = 0;
                    this.mc = 0;
                }
                else
                {
                    this.ma = ma;
                    this.mb = mb;
                    this.mc = mc;
                }
            }

            // Phương thức kiểm tra tam giác hợp lệ
            private Boolean TamGiacHopLe(double a, double b, double c)
            {
                return a + b > c && b + c > a && c + a > b;
            }

            // Getter và setter
            public double getma()
            {
                return ma;
            }

            public void setma(double ma)
            {
                if (ma > 0 && TamGiacHopLe(ma, mb, mc))
                {
                    this.ma = ma;
                }
            }

            public double getmb()
            {
                return mb;
            }

            public void setmb(double mb)
            {
                if (mb > 0 && TamGiacHopLe(ma, mb, mc))
                {
                    this.mb = mb;
                }
            }

            public double getmc()
            {
                return mc;
            }

            public void setmc(double mc)
            {
                if (mc > 0 && TamGiacHopLe(ma, mb, mc))
                {
                    this.mc = mc;
                }
            }

            // Phương thức tính chu vi
            public double calculatePerimeter()
            {
                return ma + mb + mc;
            }

            // Phương thức tính diện tích
            public double calculateArea()
            {
                double p = calculatePerimeter() / 2;
                return Math.Sqrt(p * (p - ma) * (p - mb) * (p - mc));
            }

            // Phương thức trả về thông tin kiểu tam giác
            public String getTriangleType()
            {
                if (ma == mb && mb == mc)
                {
                    return "Đều";
                }
                else if (ma == mb || mb == mc || mc == ma)
                {
                    return "Cân";
                }
                else
                {
                    return "Thường";
                }
            }

            // Phương thức toString
            public String toString()
            {
                String triangleType = getTriangleType();
                double perimeter = calculatePerimeter();
                double area = calculateArea();

                return "Cạnh a: " + ma + ", Cạnh b: " + mb + ", Cạnh c: " + mc +
                       ", Kiểu tam giác: " + triangleType + ", Chu vi: " + perimeter + ", Diện tích: " + area;
            }
        }

        public class Main
        {
            public static void main(String[] args)
            {
                Triangle triangle1 = new Triangle(-1, 2, 3); // Hình vi phạm ràng buộc
                Triangle triangle2 = new Triangle(4, 4, 7);  // Hình vi phạm ràng buộc
                Triangle triangle3 = new Triangle(3, 4, 5);  // Tam giác thường
                Triangle triangle4 = new Triangle(5, 5, 5);  // Tam giác đều
                Triangle triangle5 = new Triangle(5, 5, 7);  // Tam giác cân
            }
        }
    }






}
