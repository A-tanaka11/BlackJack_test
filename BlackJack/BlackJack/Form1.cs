using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlackJack
{
    public partial class Form1 : Form
    {
        public static DrawnCard drawnCardList;
        private PictureBox pictureBox;
        private List<PictureBox> playerPictureBoxes = new List<PictureBox>();
        private List<PictureBox> dealerPictureBoxes = new List<PictureBox>();
        private Player player;
        private Player dealer;
        private FlowLayoutPanel[] flp;      //0…プレイヤー,1…ディーラー

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //プレイヤーの作成
            player = new Player();
            //ディーラーの作成
            dealer = new Player();

            //フロアレイアウトパネルの設定
            flp = new FlowLayoutPanel[2];

            for(int i = 0; i < flp.Length; i++)
            {
                flp[i] = new FlowLayoutPanel();
                
                flp[i].Size = new Size(this.ClientSize.Width, 160);
                flp[i].Parent = this;
            }

            flp[0].Dock = DockStyle.Bottom;
            flp[1].Dock = DockStyle.Top;
            flp[1].FlowDirection = FlowDirection.RightToLeft;

            //引いたカードリストの作成
            drawnCardList = new DrawnCard();

            //プレイヤーの初期化
            for (int i = 0; i < 2; i++)
            {
                player.DrawCard(drawnCardList);
            }

            label1.Text = player.Total().ToString();
            //プレイヤーのカードの描画
            PlayerDraw();

            //ディーラーの初期化
            for(int i = 0; i < 2; i++)
            {
                dealer.DrawCard(drawnCardList);
            }
            //ディーラーのカードの描画
            DealerDraw();

        }

        //プレイヤーのカードの描画
        public void PlayerDraw()
        {
            //ピクチャボックスを削除
            foreach(PictureBox pictureBox in playerPictureBoxes)
            {
                flp[0].Controls.Remove(pictureBox);
            }

            //リストをクリア
            playerPictureBoxes.Clear();
            
            //持っているカード数ピクチャボックスを作成
            foreach (Card card in player.GetCards())
            {
                //ピクチャボックスの作成
                pictureBox = new PictureBox();
                //画像の読み込み
                Bitmap bitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject("card_" + card.Type + card.Number, Properties.Resources.Culture);
                pictureBox.Image = bitmap;

                pictureBox.Size = new Size(70,140);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Anchor = AnchorStyles.Right;
                pictureBox.Parent = flp[0];
                
                playerPictureBoxes.Add(pictureBox);
            }
        }

        //ディーラーのカードの描画
        public void DealerDraw()
        {
            //ピクチャボックスを削除
            foreach (PictureBox pictureBox in playerPictureBoxes)
            {
                flp[1].Controls.Remove(pictureBox);
            }

            //リストをクリア
            dealerPictureBoxes.Clear();

            //持っているカード数ピクチャボックスを作成
            foreach (Card card in dealer.GetCards())
            {
                //ピクチャボックスの作成
                pictureBox = new PictureBox();
                //画像の読み込み
                Bitmap bitmap = (Bitmap)Properties.Resources.ResourceManager.GetObject("card_" + card.Type + card.Number, Properties.Resources.Culture);
                pictureBox.Image = bitmap;

                pictureBox.Size = new Size(70, 140);
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.Anchor = AnchorStyles.Right;
                pictureBox.Parent = flp[1];

                dealerPictureBoxes.Add(pictureBox);
            }
        }

        public DrawnCard GetDrawnCard()
        {
            return drawnCardList;
        }

        //「ヒット」のボタンを押したとき
        private void DrawButton_Click(object sender, EventArgs e)
        {
            //カードを引く
            player.DrawCard(drawnCardList);
            //描画
            PlayerDraw();
            label1.Text = player.Total().ToString();
            //合計がバーストしてないか
            player.GetCalculation().Burst(player.Total());
        }
    }
}
