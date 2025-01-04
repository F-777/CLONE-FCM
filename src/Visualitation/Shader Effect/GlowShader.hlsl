Shader "Custom/GlowShader"
{
    Properties
    {
        _Color ("Color", Color) = (1,1,1,1)
        _Glow ("Glow Intensity", Range(0,5)) = 1.0
    }
    SubShader
    {
        Tags { "RenderType"="Transparent" }
        LOD 200

        CGPROGRAM
        #pragma surface surf Lambert

        struct Input
        {
            float4 color : COLOR;
        };

        sampler2D _MainTex;
        fixed4 _Color;
        float _Glow;

        void surf(Input IN, inout SurfaceOutput o)
        {
            o.Albedo = _Color.rgb * _Glow; // Efek cahaya intens
            o.Emission = _Color.rgb * _Glow;
        }
        ENDCG
    }
}
