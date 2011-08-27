/*
 * Copyright (C) 2010-2011 by ExampleWorks, Inc. All rights reserved.
 * LICENSE: You can't redistribute it and/or modify it.
 */
namespace Before
{
    public class Customer : ThirdParty
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public Customer(string firstName, string lastName, string phoneNumber)
            : base(phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
        }
    }
}