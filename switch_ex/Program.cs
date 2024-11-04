namespace switch_ex
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.Write("학점을 입력하세요");
            string grade = Console.ReadLine();
            switch (grade)
            {
                case "A":
                    Console.WriteLine("최고입니다");
                    break;
                    case "B":
                    Console.WriteLine("잘했습니다");
                    break;
                    case "C":
                    Console.WriteLine("조금 부족하네요");
                    break;
                    case "D":
                    Console.WriteLine("좀 더 열심히 하세요");
                    break;
                    case "F":
                    Console.WriteLine("괜찮아요 다음에 잘하면 되죠");
                    break;
                    default:
                    Console.WriteLine("점수가 잘 못 된거 같습니다");
                    break;
            }
            Console.Read();
        }
    }
}
