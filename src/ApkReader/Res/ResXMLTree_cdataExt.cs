﻿// Copyright (c) 2012 Markus Jarderot
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using System;

namespace ApkReader.Res
{
    [Serializable]
    public class ResXMLTree_cdataExt
    {
        public ResStringPool_ref Data { get; set; }
        public Res_value TypedData { get; set; }
    }
}