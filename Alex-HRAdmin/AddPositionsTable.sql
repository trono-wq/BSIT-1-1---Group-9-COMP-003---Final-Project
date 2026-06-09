USE hr_applicant_process_window_application;

CREATE TABLE Positions (
    position_id INT AUTO_INCREMENT PRIMARY KEY,
    position_name VARCHAR(100) NOT NULL,
    o_position_added_at TIMESTAMP DEFAULT CURRENT_TIMESTAMP,
    o_position_added_by INT,
    FOREIGN KEY (o_position_added_by)
        REFERENCES Users(user_id)
);


