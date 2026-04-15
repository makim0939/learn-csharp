# VSCodeでC#アプリケーションを作成・ビルド・実行する
## 前提
- 拡張機能「C#」インストール済み
- 拡張機能「C# Dev Kit」インストール済み
- .Net SDK インストール済み。(ターミナルで`dotnet` を叩いて確認)

コンソールアプリケーション作成
```
dotnet new console -o Path/To/ProjectFolder
```

ビルド（プロジェクトフォルダで実行）
```
dotnet build
```

実行（プロジェクトフォルダで実行）
```
dotnet run
```

🤔 ソリューションとプロジェクトを別々に作って紐づける。これで`sln`と`csproj`を同階層に配置可能。  
ソリューションの作成
```
dotnet new sln -n ソリューション名
```

ソリューションとプロジェクトの紐づけ
```
dotnet sln add プロジェクトへのパス.csproj
```

---
[今回学習したコース 🔗](https://learn.microsoft.com/ja-jp/training/modules/install-configure-visual-studio-code/)