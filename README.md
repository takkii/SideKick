### CSharpで[気象庁](https://www.data.jma.go.jp/obd/stats/data/mdrr/docs/csv_dl_format_prenh.html)から気象データ(csv)を取得するプログラム

| 観測所番号	| 都道府県 | 地点 | 国際地点番号 | 現在時刻(年)| 現在時刻(月) | 現在時刻(日) | 現在時刻(時) | 現在時刻(分) | 現在値(mm) | 現在値の品質情報 |
| :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: | :---: |
| 56227 |	石川県 |	金沢（カナザワ） | 47605 | 2020 | 08 | 15 | 20 | 30 | 0.0 | |

| 今日の最大値(mm) | 今日の最大値の品質情報 | 今日の最大値起時（時）(まで) | 今日の最大値起時（分）(まで) | 今日の最大値起時(まで)の品質情報 | 極値更新 |	
| :---: | :---: | :---: | :---: | :---: | :---: |
| 80.0 | 5 | 	

| 10年未満での極値更新 | 昨日までの観測史上1位の値(mm) | 昨日までの観測史上1位の値の品質情報 | 昨日までの観測史上1位の値の年 | 昨日までの観測史上1位の値の月 |
| :---: | :---: | :---: | :---: | :---: |
| | 77.3 | 8 |	1950 | 09 | 

| 昨日までの観測史上1位の値の日 | 昨日までの8月の1位の値(mm) | 昨日までの8月の1位の値の品質情報 | 昨日までの8月の1位の値の年 | 
| :---: | :---: | :---: | :---: |
| 18 |	75.7 | 8 | 1953 |

昨日までの8月の1位の値の月 | 昨日までの8月の1位の値の日 | 統計開始年 |
| :---: | :---: | :---: |
| 08 | 24 | 1937 |

### 令和2年8月15日 (取得年月日)

> プログラムはデータを取得(SJIS)し、コンマを消し見やすくしたあとファイルに書き出(UTF8)します。そこから石川県(金沢)を検索し表示するためにzinbeijettのengineを使いました。このプログラムがあれば仮にzinbei2wのAPI取得ができなくなっても(ベータ版のようなので終了するかもしれない)、代替えとして石川県(金沢)の気象情報を取得と表示ができます。手動では、検索結果の数字を当てはめるだけで、何度でも更新することができます。今日追加しましたが、また更新します。必要なときに何度でも...

#### 検証方法

```markdown
../../bin/Debug

pre01.csv → Excelなどで表示 (SJIS)
tenki.txt → zinbeijettなどで検索用 (UTF8)
```

_tenki.txtをzinbeijettのengineで検索する_

```markdown
cd ../../bin/Debug (例)
※ tenki.txtを適切なPATHへ置く

engine -z tenki.txt 金沢
※ 結果を並べる
```

#### 令和2年8月16日

_※ 降水量のテキストをcsvファイルと比べ、正規化しました_
