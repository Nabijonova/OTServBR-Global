using System;
  namespace Matrix_100
 {   
  class Program  
   {   
      public static void Main(string[] args)     
    {             int m,i,j; double s;  
           Console.Write("Kvadrat matritsa satrlari sonini kiriting: m="); 
            m=int.Parse(Console.ReadLine());  
           double [,] a=new double [m,m];

             for (i=0;i<m;i++)    
         {             
    for (j=0;j<m;j++)  
               {  
                   Console.Write("a["+i+","+j+"]=");   
                  a[i,j]=double.Parse(Console.ReadLine());  
               }  
 
          }  
           for (i=m-1;i>0;i--)  
           {   
              for (j=0;j<i;j++)
 {s=a[i,j];a[i,j]=a[j,i];a[j,i]=s;}             }             for (i=0;i<m;i++) for (j=0;j<m/2;j++){s=a[i,j];a[i,j]=a[i,m-1-j];a[i,m-1-j]=s;}             for (i=0;i<m;i++) 
           {
               for (j=0;j<m;j++) 
               Console.Write(a[i,j]+"\t");
               Console.WriteLine();
            }       
      Console.ReadKey(true);      
   }  
  } 
}
