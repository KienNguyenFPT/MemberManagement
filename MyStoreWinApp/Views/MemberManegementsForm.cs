using Microsoft.IdentityModel.Tokens;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class MemberManegementsForm : Form
    {
        public MemberManegementsForm()
        {
            InitializeComponent();

        }
        List<Member> members = new List<Member>();
        private List<object[]> originalData;

        private void AssociateAndRaiseViewEvents()
        {
            btnSearch.Click += delegate { searchEvent?.Invoke(this, EventArgs.Empty); };
            txtSearch.KeyDown += (s, e) =>
            {
                if (e.KeyCode == Keys.Enter)
                {
                    searchEvent?.Invoke(this, EventArgs.Empty);
                }
            };

        }

        //------------------
        //Events
        public event EventHandler searchEvent;
        public event EventHandler addNewEvent;
        public event EventHandler editEvent;
        public event EventHandler deleteEvent;
        public event EventHandler saveEvent;
        public event EventHandler cancelEvent;
        //-----------------
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void MemberManegementsForm_Load(object sender, EventArgs e)
        {

        }



        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private List<Member> FilterMembersByCity(string city)
        {
            List<Member> filteredMembers = new List<Member>();

            foreach (Member member in members)
            {
                if (member.City.ToLower().Contains(city.ToLower()))
                {
                    filteredMembers.Add(member);
                }
            }
            return filteredMembers;
        }

        private List<Member> FilterMembersByCountry(string country)
        {
            List<Member> filteredMembers = new List<Member>();

            foreach (Member member in members)
            {
                if (member.Country.ToLower().Contains(country.ToLower()))
                {
                    filteredMembers.Add(member);
                }
            }
            return filteredMembers;
        }

        private void UpdateDataGridView(List<Member> members)
        {
            dataGridMember.Rows.Clear();
            foreach (Member member in members)
            {
                dataGridMember.Rows.Add(member.MemberID, member.Name, member.City, member.Country, member.Email, member.Password);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string cityText = txtByCity.Text.Trim();
            List<Member> filteredMembers = FilterMembersByCity(cityText);
            UpdateDataGridView(filteredMembers);
            txtByCity.Clear();

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int selectedMemberID = (int)dataGridMember.Rows[e.RowIndex].Cells["colID"].Value;

                Member selectedMember = members.Find(m => m.MemberID == selectedMemberID);

                if (selectedMember != null)
                {
                    // Open the DetailInfo form and pass the selected member to it
                    //DetailInfo details = new DetailInfo(selectedMember, members);
                    //details.FormClosed += (sender, e) =>
                    //{
                    //    RefreshDataGridView();
                    //};
                    //details.Show();

                }
            }
        }

        private void RefreshDataGridView()
        {
            // Clear the DataGridView
            dataGridMember.Rows.Clear();

            // Repopulate the DataGridView with the updated member information
            foreach (var member in members)
            {
                dataGridMember.Rows.Add(member.MemberID, member.Name, member.City, member.Country, member.Email, member.Password);
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            tagControl.SelectedTab = tabDetail;
        }


        private HashSet<int> uniqueID = new HashSet<int>();
        private bool IsMemberIDDuplicate(int memberID)
        {
            return uniqueID.Contains(memberID) || members.Any(member => member.MemberID == memberID) || File.ReadLines("D:\\Kien FPT\\Kỳ 5 FPT_Fall23_5.9\\Kỳ 5 FPT_Fall23_5.9\\1_PRN211\\CP\\Ass01Solution\\members.txt").Any(line =>
            {
                string[] parts = line.Split(',');
                if (parts.Length >= 1 && int.TryParse(parts[0], out int existingMemberID))
                {
                    return existingMemberID == memberID;
                }
                return false;
            });
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text) || string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtCity.Text) || string.IsNullOrWhiteSpace(txtCountry.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all fields.");
                return; // Stop processing if any field is empty
            }

            if (!int.TryParse(txtID.Text, out int memberID))
            {
                MessageBox.Show("Member ID must be a valid integer.");
                return; // Stop processing if Member ID is not a valid integer
            }

            if (IsMemberIDDuplicate(memberID))
            {
                MessageBox.Show($"Member with ID: {memberID} was occured!");
                //MessageBox.Show($"Member with ID: {selectedMemberID}" + " was delete successfully!");
            }
            else
            {
                Member newMem = new Member
                {
                    MemberID = memberID,
                    Name = txtName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text
                };

                members.Add(newMem);
                uniqueID.Add(memberID);
                MessageBox.Show("Add successfully!");
                dataGridMember.Rows.Add(newMem.MemberID, newMem.Name,
                    newMem.City, newMem.Country, newMem.Email, newMem.Password);
            }



            // Update the DataGridView
            //dataGridMember.Rows.Add(newMem.MemberID, newMem.Name,
            //newMem.City, newMem.Country, newMem.Email, newMem.Password);

            // Clear the input fields
            txtID.Clear();
            txtName.Clear();
            txtCity.Clear();
            txtCountry.Clear();
            txtEmail.Clear();
            txtPassword.Clear();
            saveToFile();
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void UpdateMemberInList(List<Member> members, Member updatedMember)
        {
            Member existingMember = members.Find(m => m.MemberID == updatedMember.MemberID);
            if (existingMember != null)
            {
                existingMember.Name = updatedMember.Name;
                existingMember.City = updatedMember.City;
                existingMember.Country = updatedMember.Country;
                existingMember.Email = updatedMember.Email;
                existingMember.Password = updatedMember.Password;
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridMember.SelectedRows.Count > 0)
            {
                int selectedMemberID = (int)dataGridMember.SelectedRows[0].Cells["colID"].Value;
                Member selectedMember = members.Find(m => m.MemberID == selectedMemberID);
                if (selectedMember != null)
                {
                    DetailInfo detailForm = new DetailInfo(selectedMember);
                    if (detailForm.ShowDialog() == DialogResult.OK)
                    {
                        Member updatedMember = detailForm.getUpdated();
                        UpdateMemberInList(members, updatedMember);
                        UpdateDataGridView(members);
                        MessageBox.Show("Member information updated successfully!");
                        saveToFile();
                    }
                }
                else
                {
                    MessageBox.Show("Selected member not found in the list.");
                }
            }

        }

        private void tagControl_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCountry_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtCity_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
        }

        private void label7_Click(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void label5_Click(object sender, EventArgs e)
        {
        }

        private void label4_Click(object sender, EventArgs e)
        {
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void id_Click(object sender, EventArgs e)
        {
        }

        private void sortDescendingByName()
        {
            members = members.OrderByDescending(members => members.Name).ToList();
        }


        private void showList(List<Member> sortedList)
        {
            dataGridMember.Rows.Clear();
            foreach (Member member in sortedList)
            {
                dataGridMember.Rows.Add(member.MemberID, member.Name, member.City, member.Country, member.Email, member.Password);
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            sortDescendingByName();
            showList(members);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridMember.SelectedRows.Count > 0)
            {
                int selectedMemberID = (int)dataGridMember.SelectedRows[0].Cells["colID"].Value;

                // Debug: Display the selected member ID
                //MessageBox.Show($"Selected Member ID: {selectedMemberID}");
                Member selectedMember = members.Find(m => m.MemberID == selectedMemberID);
                if (selectedMember != null)
                {
                    // Display a confirmation message
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this member?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    // Check if the user confirmed the deletion
                    if (result == DialogResult.Yes)
                    {
                        // Remove the selected member from the list
                        members.Remove(selectedMember);
                        MessageBox.Show($"Member with ID: {selectedMemberID}" + " was delete successfully!");
                        saveToFile();
                        // Update the data grid view
                        UpdateDataGridView();

                        // Optionally, you can save the updated member list to your data storage (e.g., app.config, a file, or a database).
                        // SaveMembersToStorage();
                    }
                }
                else
                {
                    // Debug: Display a message if the member was not found
                    MessageBox.Show("Selected member not found in the list.");
                }
            }
            else
            {
                // Debug: Display a message if no rows are selected
                MessageBox.Show("No row selected.");
            }
        }

        private void saveToFile()
        {
            try
            {
                string filePath = "D:\\Kien FPT\\Kỳ 5 FPT_Fall23_5.9\\Kỳ 5 FPT_Fall23_5.9\\1_PRN211\\CP\\Ass01Solution\\members.txt";
                File.WriteAllText(filePath, string.Empty);
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    foreach (Member member in members)
                    {
                        string memberData = $"{member.MemberID},{member.Name},{member.City},{member.Country},{member.Email},{member.Password}";
                        writer.WriteLine(memberData);
                    }
                }
                // Display a message to indicate successful save

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving members data: {ex.Message}");
            }
        }

        private void UpdateDataGridView()
        {
            dataGridMember.Rows.Clear();
            foreach (Member member in members)
            {
                dataGridMember.Rows.Add(
                    member.MemberID.ToString(),
                    member.Name,
                    member.City,
                    member.Country,
                    member.Email,
                    member.Password
                );
            }
        }

        private void SearchMembers(string searchText)
        {
            List<object[]> currentData = new List<object[]>();

            // Store a flag indicating whether any matching member was found
            bool found = false;

            foreach (DataGridViewRow row in dataGridMember.Rows)
            {
                if (row.Cells["colID"].Value != null && row.Cells["colName"].Value != null)
                {
                    int memberID;
                    if (int.TryParse(row.Cells["colID"].Value.ToString(), out memberID))
                    {
                        string memberName = row.Cells["colName"].Value.ToString();

                        if (memberID.ToString().Contains(searchText) || memberName.Contains(searchText))

                        {
                            currentData.Add(row.Cells.Cast<DataGridViewCell>().Select(cell => cell.Value).ToArray());
                            found = true;
                        }
                    }
                }
            }

            if (found)
            {
                // Clear the DataGridView
                dataGridMember.Rows.Clear();

                // Add the matching members back to the DataGridView
                foreach (object[] rowData in currentData)
                {
                    dataGridMember.Rows.Add(rowData);
                }
            }
            else
            {
                // Show a notification if no matching member is found
                MessageBox.Show("No members was found!");

                // You can optionally restore the original data in the DataGridView if needed
                UpdateDataGridView();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.Trim();
            SearchMembers(searchText);
            txtSearch.Clear();
        }


        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
        }

        private void label2_Click_1(object sender, EventArgs e)
        {
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {
        }

        private void LoadMembersFromFile(string filePath)
        {
            try
            {
                string[] lines = File.ReadAllLines(filePath);
                members.Clear();
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 6)
                    {
                        Member member = new Member
                        {
                            MemberID = int.Parse(parts[0]),
                            Name = parts[1],
                            City = parts[2],
                            Country = parts[3],
                            Email = parts[4],
                            Password = parts[5]
                        };
                        members.Add(member);

                    }
                }
                // Display the loaded data in the DataGridView
                dataGridMember.Rows.Clear();
                UpdateDataGridView(members);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading members data: {ex.Message}");
            }
        }

        bool isLoaded = false;
        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (!isLoaded)
            {
                string filePath = "D:\\Kien FPT\\Kỳ 5 FPT_Fall23_5.9\\Kỳ 5 FPT_Fall23_5.9\\1_PRN211\\CP\\Ass01Solution\\members.txt"; // Update this with the correct file path
                LoadMembersFromFile(filePath);
                isLoaded = true;
            }
            else
            {
                MessageBox.Show("Data have already loaded!");
            }
        }

        private void ResetDataGridView()
        {
            UpdateDataGridView(members);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnByCountry_Click(object sender, EventArgs e)
        {
            string countryText = txtByCountry.Text.Trim();
            List<Member> filteredMembers = FilterMembersByCountry(countryText);
            UpdateDataGridView(filteredMembers);
            txtByCountry.Clear();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit(); 
        }
    }
}
