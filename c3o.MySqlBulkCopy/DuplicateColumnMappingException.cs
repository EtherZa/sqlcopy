﻿/* 
 * IndiansInc.MySqlBulklCopy
 * Helpful to copy a huge data set from one Mysql table to another.
 * Requirements: .NET Framework 3.5/Mono
 * Copyright (c) 2012 IndiansInc.MySqlBulkcopy (http://code.google.com/p/mysqlbulkcopy/)
 * This program is free software; you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation; version 2 of the license.
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
 * GNU General Public License for more details.
 *
 */

namespace IndiansInc.Internals
{
    /*
     * DuplicateColumnMappingException
     * This class represents the duplicate column mapping exception that will be raised when a destiation column recieves two source columns as its map.
     * @author   Albert Arul Prakash<albertarulprakash@gmail.com>  
     */

    using System;

    public class DuplicateColumnMappingException : Exception
    {
        public DuplicateColumnMappingException(string message)
            : base(message) { }

        public DuplicateColumnMappingException(string message, Exception innerException)
            : base(message, innerException) { }
    }
}
