using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingGame
{
    public partial class ShootingForm : Form
    {
        Setting obj = new Setting();
        Random bulletno = new Random();
        int sound = 0,bullet=0;
        int shootClk = 0;
        
        public ShootingForm()
        {
            InitializeComponent();

            

            pbGun.Image= Properties.Resources.bullet;
            MessageBox.Show("Welcome to the shooting game \n You have only two chance to save yourself");
            groupBox1.Visible = true;
            Btn_Load.Enabled = true;
        }
             

        private void btn_Load_Click(object sender, EventArgs e)
        {
            pb_Gun.Image=Properties.Resources.load;
            btn_spin.Enabled = true;
            Btn_Load.Enabled = false;
        }

        private void btn_Spin_Click(object sender, EventArgs e)
        {
            sound = obj.fire();
            pb_Gun.Image = Properties.Resources.spin;
            btn_Shoot.Enabled = true;
            btn_Shoot_Away.Enabled = true;

            btn_spin.Enabled = false;
        }

        private void btn_Shoot_Click(object sender, EventArgs e)
        {
            // this code is uused when we click on the shoot away button to fire 

            pb_Gun.Image = Properties.Resources.gun;

            shootClk++;
            //if the clik and sound generation value is equal then the message will print and create the sound of fire other wise the empty sound will sound
            if (shootClk == sound)
            {
                pbGun.Visible = true;

                // enable the timer to work
                timer1.Start();
                // generate the sound of the  fire trigger 
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fire);
                player.Play();
                findWinner();
               
                
            }else {
                // generate the sound of the  empty trigger 
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Empty);
                player.Play();
                MessageBox.Show("Retry to Shoot ");

            }
            if (shootClk==4 && shootClk!=sound) {
                MessageBox.Show("congrats! your player is survive ");
                btn_Shoot.Enabled = false;
                btn_try_Again.Enabled = true;
            }

        }
         //tooe code to find the winner of the game if the player win the game other wise it will generate an error 
        public void findWinner() {
            btn_Shoot_Away.Enabled = false;
            btn_Shoot.Enabled = false;
            btn_try_Again.Visible = true;

            MessageBox.Show("Player is dead ! Click on retry to play again");
            pbGun.Visible = false;
            pbGun.Left = 195;
        }
            // when this is last chance then the game over messsage will display and reset the game will print 

          
           
        
        // this code is used to try again the game again to play 
        public void reset() {

            //reset all global variable 
            bullet = 0;
            shootClk = 0;
            //calling the method of the sound 
            sound = obj.rd.Next(1, 6);
            //reseet the gun image 
            pb_Gun.Image = Properties.Resources._1st;
            

        }

        private void btn_try_again_Click(object sender, EventArgs e)
        {
            btn_try_Again.Visible = false;
            groupBox1.Visible = true;
            Btn_Load.Enabled = true;

            bullet = 0;
            shootClk = 0;
        }

        private void Btn_Shoot_away_Click(object sender, EventArgs e)
        {
            bullet++;
            if (bullet == sound)
            {

                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.fire);
                player.Play();
                MessageBox.Show("Thank God ! Player is alive ");
                btn_Shoot_Away.Enabled = false;
                btn_try_Again.Visible = true;
            }
            else {
                System.Media.SoundPlayer player = new System.Media.SoundPlayer(Properties.Resources.Empty);
                player.Play();
            }

            if (bullet==2) {

                MessageBox.Show("Ending up!!");
                btn_Shoot_Away.Enabled = false;
                btn_try_Again.Visible = true;
                bullet = 0;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            // when the bullet will reach at destination then the timer will stop automatically 
            if (pbGun.Left>600) {
                timer1.Stop();

            }
            // move the image of the bullet 
            pbGun.Left = pbGun.Left + obj.rd.Next(1, 34);

            //button1.Text = "" + pbGun.Left;
        }
    }
}
