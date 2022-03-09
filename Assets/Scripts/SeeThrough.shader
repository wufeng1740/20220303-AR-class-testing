Shader "Unlit/SeeThrough"
{

    SubShader
    {
        Tags {"Queue" = "Transparent+1"}    // convert it to 3001 queue

        Pass { Blend Zero One }    
    }
}
