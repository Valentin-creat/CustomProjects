//
//  StorageManager.swift
//  SoftUniQuickNotes
//
//  Created by Ivan Chavdarov Ivanov on 30.01.24.
//

import Foundation

class StorageManager {
    
    private let userDefaults = UserDefaults.standard
    private let noteKey = "note"
    
    var notesArray = [String]()
    
    var isThereSavedNotes: Bool {
        ((userDefaults.object(forKey: noteKey) as? [String]) != nil) ? true : false
    }
    
    func getNotes(completion: @escaping () -> Void) {
        notesArray = userDefaults.object(forKey: noteKey) as? [String] ?? []
        completion()
    }
    
    func saveNote(note: String) {
        notesArray.append(note)
        saveNotes()
    }
    
    func deleteNote(at index: Int) {
        notesArray.remove(at: index)
        if !notesArray.isEmpty {
            saveNotes()
        } else {
            userDefaults.removeObject(forKey: noteKey)
        }
    }
    
    func deleteAllNotes() {
        notesArray.removeAll()
        userDefaults.removeObject(forKey: noteKey)
    }
    
    private func saveNotes() {
        userDefaults.set(notesArray, forKey: noteKey)
    }
}
