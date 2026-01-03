using System;
class AddGenericClass<T>
{
    T n1;
    T n2;
    T result;

    public T MyProperty { get; set; } //can take property
    //generic default constructor
    public AddGenericClass()
    {
        
    }
    //generic parameterized constructor
    public AddGenericClass(T m,T n)
    {
        this.n1=m;
        this.n2=n;
    }
    public T AddAllType(T num1,T num2) //generic method
    {
        dynamic x=num1;
        dynamic y=num2;
        result =x+y;
        return result;
    }
}