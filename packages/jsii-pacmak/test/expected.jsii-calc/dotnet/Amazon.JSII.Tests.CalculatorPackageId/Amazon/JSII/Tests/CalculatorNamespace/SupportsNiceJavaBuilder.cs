using Amazon.JSII.Runtime.Deputy;

namespace Amazon.JSII.Tests.CalculatorNamespace
{
    /// <remarks>
    /// <strong>Stability</strong>: Experimental
    /// </remarks>
    [JsiiClass(nativeType: typeof(Amazon.JSII.Tests.CalculatorNamespace.SupportsNiceJavaBuilder), fullyQualifiedName: "jsii-calc.SupportsNiceJavaBuilder", parametersJson: "[{\"docs\":{\"summary\":\"some identifier.\"},\"name\":\"id\",\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"the default value of `bar`.\"},\"name\":\"defaultBar\",\"optional\":true,\"type\":{\"primitive\":\"number\"}},{\"docs\":{\"summary\":\"some props once can provide.\"},\"name\":\"props\",\"optional\":true,\"type\":{\"fqn\":\"jsii-calc.SupportsNiceJavaBuilderProps\"}},{\"docs\":{\"summary\":\"a variadic continuation.\"},\"name\":\"rest\",\"type\":{\"primitive\":\"string\"},\"variadic\":true}]")]
    public class SupportsNiceJavaBuilder : Amazon.JSII.Tests.CalculatorNamespace.SupportsNiceJavaBuilderWithRequiredProps
    {
        /// <param name="id">some identifier.</param>
        /// <param name="defaultBar">the default value of `bar`.</param>
        /// <param name="props">some props once can provide.</param>
        /// <param name="rest">a variadic continuation.</param>
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        public SupportsNiceJavaBuilder(double id, double? defaultBar = null, Amazon.JSII.Tests.CalculatorNamespace.ISupportsNiceJavaBuilderProps props = null, params string[] rest): base(new DeputyProps(new object[]{id, defaultBar, props, rest}))
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from a Javascript-owned object reference</summary>
        /// <param name="reference">The Javascript-owned object reference</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SupportsNiceJavaBuilder(ByRefValue reference): base(reference)
        {
        }

        /// <summary>Used by jsii to construct an instance of this class from DeputyProps</summary>
        /// <param name="props">The deputy props</param>
        [System.ComponentModel.EditorBrowsable(System.ComponentModel.EditorBrowsableState.Never)]
        protected SupportsNiceJavaBuilder(DeputyProps props): base(props)
        {
        }

        /// <summary>some identifier.</summary>
        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiProperty(name: "id", typeJson: "{\"primitive\":\"number\"}")]
        public override double Id
        {
            get => GetInstanceProperty<double>();
        }

        /// <remarks>
        /// <strong>Stability</strong>: Experimental
        /// </remarks>
        [JsiiProperty(name: "rest", typeJson: "{\"collection\":{\"elementtype\":{\"primitive\":\"string\"},\"kind\":\"array\"}}")]
        public virtual string[] Rest
        {
            get => GetInstanceProperty<string[]>();
        }
    }
}
