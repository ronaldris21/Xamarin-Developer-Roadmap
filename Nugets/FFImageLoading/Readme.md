FFImageLoading

**First add the Nuget**
Using Package Manage Console
```
Install-Package Xamarin.FFImageLoading.Forms -Version 2.4.11.982
```


```
<PackageReference Include="Xamarin.FFImageLoading.Forms" Version="2.4.11.982" />
```



1. Init
	**IOS:**
   ```csharp 
		FFImageLoading.Forms.Platform.CachedImageRenderer.Init();   
	```
	**Android:**
	```csharp
		FFImageLoading.Forms.Platform.CachedImageRenderer.Init(enableFastRenderer: true);
	```

2. Ejemplo

	**XAML**
	Inicializarlo
	```xaml
       xmlns:ffimage="clr-namespace:FFImageLoading.Forms;assembly=FFImageLoading.Forms"
	```
	Ahora lo usamos
	```xaml
		<ffimage:CachedImage    Source="{Binding card.imageSelected}"
                                Aspect="AspectFit"
                                LoadingPlaceholder="BackCard.png"
                                ErrorPlaceholder="BackCard.png"
                                CacheDuration="10"
                                RetryCount="1"
                                CacheType="Disk"
                                >
	```
		
