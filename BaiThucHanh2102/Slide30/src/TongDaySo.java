import java.util.Scanner;
class TongDaySo {
    public static int sum(int n){
        int tong=0;
        while(n>0)
        {
            int du=n%10;
            tong=tong+du;
            n=n/10;
        }       
        return tong;
    }
    public static void main(String[] args) throws Exception {
        Scanner sc = new Scanner(System.in);
        System.out.println("Nhap n:");
        int n =sc.nextInt();
        int sum=sum(n);
        System.out.println(sum);
    }
}
