import java.util.Scanner;
public class PTBac2 {
    public static void main(String[] args) throws Exception {
        Scanner sc=new Scanner(System.in);
        double a,b,c=0;
        double x,x1,x2,delta=0; 
        System.out.println("Phuong trinh co dang ax^2+bx+c=0");
        System.out.print("Nhap a="); a=sc.nextDouble();
        System.out.print("Nhap b="); b=sc.nextDouble();
        System.out.print("Nhap c="); c=sc.nextDouble();
        delta =Math.pow(b,2)-4*a*c;
        if(a==0){
            if(b==0)
                System.out.println("Phuong trinh vo nghiem");
            else{
                x=-b/a;
                System.out.println("x="+x);
            }
        }
        else{
            if(delta>0){
                x1=(-b+(Math.sqrt(delta)))/2*a;
                x2=(-b-(Math.sqrt(delta)))/2*a;
                System.out.println("x1="+x1+"x2="+x2);
            }
            else if(delta==0){
                x1=-b/2*a;    
                System.out.println(x1);    
            }  
            else
            System.out.println("Phuong trinh vo nghiem");
        }
    }
}
