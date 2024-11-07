window.addEventListener("keydown", function (event){
    DotNet.invokeMethodAsync('Rubik', 'OnKeyDown', event.key)
        .catch(error => console.error(error));
});