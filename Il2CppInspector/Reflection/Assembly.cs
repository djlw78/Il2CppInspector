using System;
using System.Collections.Generic;

namespace Il2CppInspector.Reflection {
    public class Assembly
    {
        // IL2CPP-specific data
        public Il2CppImageDefinition Definition { get; }
        public int Index { get; }

        // TODO: CustomAttributes

        // Name of the assembly
        public string FullName { get; }

        // Entry point method for the assembly
        public MethodInfo EntryPoint { get; }

        // List of types defined in the assembly
        public List<Type> DefinedTypes { get; } = new List<Type>();

        // Get a type from its string name
        public Type GetType(string typeName) {
            throw new NotImplementedException();
        }

        // Initialize from specified assembly index in package
        public Assembly(Il2CppInspector pkg, int imageIndex) {
            Definition = pkg.Metadata.Images[imageIndex];
            Index = Definition.assemblyIndex;
            FullName = pkg.Metadata.Strings[Definition.nameIndex];

            if (Definition.entryPointIndex != -1) {
                // TODO: Generate EntryPoint method from entryPointIndex
            }

            // TODO: Generate types in DefinedTypes from typeStart to typeStart+typeCount-1
        }
    }
}