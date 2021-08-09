class program
{
    static void Main()
    {
        Base_class obj1 = new Base_class();
        Base_class obj2 = new Derived_class();
        Derived_class obj3 = new Derived_class();

        obj1.writeNum(28);
        obj1.writeStr("Rachel");

        obj2.writeNum(30);
        obj2.writeStr("Ross");

        obj3.writeNum(29);
        obj3.writeStr("Joey");

        System.Console.ReadKey();

    }
}
