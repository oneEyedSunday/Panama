﻿namespace Panama.Entities
{
    public class KeyValuePair : IModel
    {
        public int _ID { get; set; }
        public string Key { get; set; }
        public object Value { get; set; }
    }
}
