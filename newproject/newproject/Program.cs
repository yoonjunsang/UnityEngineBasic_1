namespace newproject
{
    //철수 객체 할당할 때 필요한 메모리 : 8byte (멤버변수 크기 총 합)
    class 철수
    {
        uint 나이;
        int 돈;
    }

    //영희 객체 할당할 때 필요한 메모리 : 4byte
    class 영희
    {
        uint 나이;
    }



    //메인함수, 프로그램 실행시 처음 호출되는 (실행되는) 함수.
    internal class Program
    {
        //변수
        // : 아직 정해지지 않은 값.
        
        // 멤버 변수
        // 사용자 정의 자료형에서 특정 공간을 구성하는 구성원으로 정의된 변수
        int a;
        uint b;
        short c;
        ushort d;
        long e;
        ulong f;
        char g;
        float h;
        double i;
        bool j;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
}