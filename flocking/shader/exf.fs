#version 330 core
out vec4 FragColor;

in vec3 ourColor;
flat in int Selected;
in vec2 TexCoord;

uniform sampler2D texture1;
uniform sampler2D texture2;

void main()
{
    // FragColor = vec4(ourColor, 1.0);
    if (Selected == 0){
        FragColor = vec4(1.0, 0.0, 0.0, 1.0);
    } else FragColor = mix(texture(texture1, TexCoord), texture(texture2, TexCoord), 0.2);
}
