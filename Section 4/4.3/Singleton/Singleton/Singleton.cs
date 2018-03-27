﻿namespace Singleton
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton() { }

        static Singleton()
        {
            _instance = new Singleton();
        }

        public static Singleton Instance
        {
            get { return _instance; }
        }
    }
}
