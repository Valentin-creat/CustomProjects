//
//  ViewController.swift
//  SoftUniQuickNotes
//
//  Created by Ivan Chavdarov Ivanov on 30.01.24.
//

import UIKit

class ViewController: UIViewController {
    
    @IBOutlet weak var tableView: UITableView!
    @IBOutlet weak var textView: UITextView!
    @IBOutlet weak var saveButton: UIButton!
    @IBOutlet weak var viewNotesButton: UIButton!
    
    private var storageManager: StorageManager = StorageManager()
    private var motionManager: MotionManager = MotionManager()
    private let feedbackGenerator = UIImpactFeedbackGenerator(style: .heavy)
    
    override func viewDidLoad() {
        super.viewDidLoad()
        
        setBackground(withImageNamed: "background")
        setDelegates()
        setupUI()
        updateButtonStates()
        setTapGesture()
    }
    
    override func viewWillAppear(_ animated: Bool) {
        motionManager.startAccelerometerUpdates()
    }
    
    override func viewWillDisappear(_ animated: Bool) {
        motionManager.stopAccelerometerUpdates()
    }
    
    @IBAction func tappedAround(_ sender: UITapGestureRecognizer) {
        textView.resignFirstResponder()
    }
    
    private func setTapGesture() {
        let tapGesture = UITapGestureRecognizer(target: self, action: #selector(tappedAround))
        view.addGestureRecognizer(tapGesture)
    }
    
    private func setDelegates() {
        tableView.dataSource = self
        tableView.delegate = self
        textView.delegate = self
        motionManager.delegate = self
    }
    
    private func setupUI() {
        
        let buttons = [("Save", saveButton), ("View Notes", viewNotesButton)]
        
        for (title, button) in buttons {
            button?.setTitle(title, for: .normal)
            button?.setTitleColor(.black, for: .normal)
            button?.setTitleColor(.lightGray, for: .disabled)
            button?.titleLabel?.font = UIFont.boldSystemFont(ofSize: 16)
            button?.layer.borderWidth = 1.0
            button?.layer.borderColor = UIColor.lightGray.cgColor
            button?.layer.cornerRadius = 20.0
            button?.clipsToBounds = true
            button?.backgroundColor = UIColor(white: 1, alpha: 0.7)
        }
        
        textView.backgroundColor = .white
        textView.layer.borderWidth = 1.0
        textView.layer.borderColor = UIColor.lightGray.cgColor
        textView.layer.cornerRadius = 8.0
        textView.clipsToBounds = true
        textView.font = UIFont.systemFont(ofSize: 20)
        textView.textColor = .black
        textView.layer.shadowColor = UIColor.black.cgColor
        textView.layer.shadowOpacity = 0.7
        textView.layer.shadowOffset = CGSize(width: 5, height: 5)
        textView.layer.shadowRadius = 5
        textView.layer.opacity = 0.7
    }
    
    private func updateButtonStates() {
        saveButton.isEnabled = !textView.text.isEmpty
        viewNotesButton.isHidden = !storageManager.isThereSavedNotes
    }
    
    
    @IBAction func saveBtnTapped(_ sender: Any) {
        guard let text = textView.text, !text.isEmpty else { return }
        
        storageManager.saveNote(note: text)
        textView.text = nil
        updateButtonStates()
    }
    
    @IBAction func viewNotesBtnTapped(_ sender: Any) {
        storageManager.getNotes {
            self.tableView.reloadData()
        }
    }
    
    private func deleteAllNotes() {
        let alert = UIAlertController(title: "Delete notes", message: "Are you sure to delete all notes?", preferredStyle: .alert)
        
        alert.addAction(UIAlertAction(title: "Cancel", style: .cancel))
        alert.addAction(UIAlertAction(title: "Delete", style: .destructive, handler: { [ weak self ] _ in
            self?.storageManager.deleteAllNotes()
            
            DispatchQueue.main.async {
                self?.tableView.reloadData()
                self?.updateButtonStates()
            }
        }))
        
        present(alert, animated: true)
    }
}

extension ViewController: UITableViewDataSource, UITableViewDelegate {
    func tableView(_ tableView: UITableView, numberOfRowsInSection section: Int) -> Int {
        storageManager.notesArray.count
    }
    
    func tableView(_ tableView: UITableView, cellForRowAt indexPath: IndexPath) -> UITableViewCell {
        let cell = tableView.dequeueReusableCell(withIdentifier: "Cell", for: indexPath)
        var contentConfig = UIListContentConfiguration.cell()
        contentConfig.text = storageManager.notesArray[indexPath.row]
        contentConfig.textProperties.color = UIColor.black
        
        cell.contentConfiguration = contentConfig
        
        return cell
    }
    
    func tableView(_ tableView: UITableView, commit editingStyle: UITableViewCell.EditingStyle, forRowAt indexPath: IndexPath) {
        if editingStyle == .delete {
            storageManager.deleteNote(at: indexPath.row)
            tableView.deleteRows(at: [indexPath], with: .fade)
            updateButtonStates()
        }
    
        
    }
    
    
}

extension ViewController: UITextViewDelegate {
    func textViewDidChange(_ textView: UITextView) {
        updateButtonStates()
    }
}

extension ViewController: MotionManagerDelegate {
    func didDetectTilt() {
        feedbackGenerator.impactOccurred()
        deleteAllNotes()
    }
}

