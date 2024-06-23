using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;



namespace WindowsFormsAppTest
{
    public partial class Form1 : Form
    {
        private BindingSource _bindingSource;
        private DataTable _table;

        //必要な分パスを追加する
        private const string CSV_PATH = "csvs\\stageData.csv";

        private const int MAX_ROWS = 15;

        public Form1()
        {
            InitializeComponent();
            
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            // フォームがロードされたときにCSVファイルを読み込みます
            // 色々選択されたときに動くよう変える
            LoadCsv(CSV_PATH);
        }

        private void LoadCsv(string filePath)
        {
            DataTable tempTable = new DataTable();

            using (StreamReader sr = new StreamReader(filePath))
            {
                // 最初の行（ヘッダー）を読み込みます
                string[] headers = sr.ReadLine().Split(',');
                foreach (string header in headers)
                {
                    // すべての列を最初にstring型で追加します
                    tempTable.Columns.Add(header, typeof(string));
                }

                // 残りの行を読み込みます
                while (!sr.EndOfStream)
                {
                    string[] rows = sr.ReadLine().Split(',');
                    DataRow dr = tempTable.NewRow();
                    for (int i = 0; i < headers.Length; i++)
                    {
                        dr[i] = rows[i];
                    }
                    tempTable.Rows.Add(dr);

                    // 行数をチェックし、10行を超えた場合は読み込みを中止します
                    if (tempTable.Rows.Count >= MAX_ROWS)
                    {
                        break;
                    }
                }
            }

            // 新しいDataTableを作成し、適切な型の列を追加します
            DataTable dataTable = new DataTable();
            foreach (DataColumn column in tempTable.Columns)
            {
                //tempTable.AsEnumerable().All()は対象のテーブルの列全てを見る,AsEnumerable()はラムダ式用の仮の変数を定義する
                // 列のデータ全てがが "true" または "false" の場合、bool型の列として追加する
                // tempTableの全要素をboolか否かラムダで回す,判定の出力は破棄
                if (tempTable.AsEnumerable().All(row => bool.TryParse(row[column].ToString(), out _) || row[column].ToString()==""))
                {
                    dataTable.Columns.Add(column.ColumnName, typeof(bool));
                }
                else
                {
                    dataTable.Columns.Add(column.ColumnName, typeof(string));
                }
            }

            // 新しいDataTableにデータをコピーします
            foreach (DataRow tempRow in tempTable.Rows)
            {
                DataRow newRow = dataTable.NewRow();
                foreach (DataColumn column in tempTable.Columns)
                {
                    if (dataTable.Columns[column.ColumnName].DataType == typeof(bool)) 
                    {
                        //空白の行は無視する
                        if(tempRow[column].ToString() != "")
                        {
                            newRow[column.ColumnName] = Convert.ToBoolean(tempRow[column]);
                        }
                        
                    }
                    else
                    {
                        newRow[column.ColumnName] = tempRow[column];
                    }
                }
                dataTable.Rows.Add(newRow);
            }

            // DataGridViewにDataTableをバインドします
            dataGridView.DataSource = dataTable;

            // DataGridViewの各列をチェックし、bool型の列にはチェックボックスを表示します
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                if (column.ValueType == typeof(bool))
                {
                    column.CellTemplate = new DataGridViewCheckBoxCell();
                }
            }

            // イベントハンドラに処理を追加（行追加で呼び出し）
            dataGridView.UserAddedRow += DataGridView_UserAddedRow;
        }

        private void SaveCsv(string filePath)
        {
            // DataGridViewのデータをDataTableとして取得します
            DataTable dataTable = (DataTable)dataGridView.DataSource;

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                // カラムヘッダーを書き込みます
                string[] columnNames = dataTable.Columns.Cast<DataColumn>()
                                        .Select(column => column.ColumnName)
                                        .ToArray();
                sw.WriteLine(string.Join(",", columnNames));

                // 各行のデータを書き込みます
                foreach (DataRow row in dataTable.Rows)
                {
                    // bool型の値を文字列("true"/"false")に変換して書き込みます
                    string[] fields = row.ItemArray.Select(field =>
                        field is bool ? (bool)field ? "true" : "false" : field.ToString())
                                       .ToArray();
                    sw.WriteLine(string.Join(",", fields));
                }
            }
        }
        private void DataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            // 新しい行が追加された時に行数をチェック
            if (dataGridView.Rows.Count > MAX_ROWS + 1) // +1は新しい行のため
            {
                MessageBox.Show("オブジェクトの上限数に達しました。これ以上追加できません。");
                dataGridView.Rows.RemoveAt(dataGridView.Rows.Count - 2); // 最後から2番目の行を削除（新しい行の前の行）
            }
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            // 編集後の内容をCSVファイルに保存します
            SaveCsv(CSV_PATH);
        }


        private void checkedListBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ObjectTypeLabel_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 選択されている行を削除
            foreach (DataGridViewRow row in dataGridView.SelectedRows)
            {
                if (row == null) return;
                dataGridView.Rows.Remove(row);
            }
        }
    }
}
