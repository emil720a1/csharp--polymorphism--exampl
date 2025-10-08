
record class PointRecord(string Name, int age, int height);

class Program
{
    static void Main()
    {
        // var tuple = (name: "Oleg", age: 18, height: 179);
        (string, int, int ) tuple = (name: "Oleg", age: 18, height: 180);
         Console.WriteLine(tuple.Item2);
         (string, int, int) GetPersonInfo() => (name: "Oleg", age: 18, height: 180);
         var tuple2 = GetPersonInfo();
         Console.WriteLine(tuple2.Item1);
         
         
         var pointRecord = new PointRecord("Oleg", 18, 180);
         (string name, int age, int height) = pointRecord;

         var second = pointRecord with { Name = "McOleg", age = 21 };
         Console.WriteLine($"pointRecord {pointRecord.Name}");
         
         Console.WriteLine($"second {second.Name}");



    }
}
