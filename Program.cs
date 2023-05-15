using System;

class Program
{
    static void Main()
    {
        
        Console.Write("ความจุของถังน้ำ: ");
        double Vmax = double.Parse(Console.ReadLine());

        Console.Write("ปริมาตรน้ำเฉลี่ยที่ผู้เข้าร่วมโครงการดื่มในแต่ละช่วงพัก: ");
        double Vdrink = double.Parse(Console.ReadLine());

        Console.Write("ปริมาตรน้ำที่เติมได้ในแต่ละรอบเติมน้ำ: ");
        double Vfill = double.Parse(Console.ReadLine());

        Console.Write("ระยะเวลาคั่นระหว่างช่วงพัก: ");
        double tdrink = double.Parse(Console.ReadLine());

        Console.Write("ระยะเวลาคั่นระหว่างรอบเติมน้ำ: ");
        double tfill = double.Parse(Console.ReadLine());

        Console.Write("ระยะเวลารวมของกิจกรรมตั้งแต่เริ่มจนจบวัน: ");
        double tday = double.Parse(Console.ReadLine());

        // คำนวณปริมาตรน้ำที่ต้องเติมในแต่ละวัน
        double Vtotal = (Vdrink * (tday / (tdrink + tfill))) + Vfill * (tday / tfill);

        // ตรวจสอบปริมาณน้ำที่เหลือ
        if (Vtotal <= Vmax)
        {
            Console.WriteLine("Enough Water, {0} left", Vmax - Vtotal);
        }
        else if (Vtotal <= Vmax + Vfill)
        {
            Console.WriteLine("Overflow Water");
        }
        else
        {
            Console.WriteLine("Not Enough Water");
        }

        Console.ReadLine();
    }
}
