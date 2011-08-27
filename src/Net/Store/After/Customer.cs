/*
 * Copyright (C) 2010-2011 by ExampleWorks, Inc. All rights reserved.
 * LICENSE: You can't redistribute it and/or modify it.
 */
namespace After
{
    public class Customer
    {
        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public PhoneNumber PhoneNumber { get; private set; }

        public string ContactName { get; set; }

        public Customer(string firstName, string lastName, PhoneNumber phoneNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;
        }

        public string FormatPhone()
        {
            return this.PhoneNumber.Format();
        }
    }
}