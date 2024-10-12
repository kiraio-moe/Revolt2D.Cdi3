namespace Revolt2D.Cdi.Json
{
    public class Cdi3
    {
        public int Version;
        public List<Parameter> Parameters;
        public List<ParameterGroup> ParameterGroups;
        public List<Part> Parts;
        public List<List<string>> CombinedParameters;

        public override string ToString()
        {
            string parametersString = string.Join(
                "\n",
                Parameters.Select((p, i) => $"  Parameter[{i}]:\n{p}")
            );
            string parameterGroupsString = string.Join(
                "\n",
                ParameterGroups.Select((p, i) => $"  Parameter Group[{i}]:\n{p}")
            );
            string partsString = string.Join("\n", Parts.Select((p, i) => $"  Part[{i}]:\n{p}"));
            string combinedParametersString = string.Join(
                "\n",
                CombinedParameters.Select(
                    (cp, cpi) =>
                        $"  Combined Parameter Group[{cpi}]:\n"
                        + string.Join(
                            "\n",
                            cp.Select((p, i) => $"    Combined Parameter[{i}]: {p}")
                        )
                )
            );
            return $"Version: {Version}\nParameters:\n{parametersString}\nParameter Groups:\n{parameterGroupsString}\nParts: {partsString}\nCombined Parameters:\n{combinedParametersString}";
        }
    }
}
