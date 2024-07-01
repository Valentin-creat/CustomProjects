//
//  UIViewController+Extensions.swift
//  SoftUniQuickNotes
//
//  Created by Ivan Chavdarov Ivanov on 30.01.24.
//

import UIKit

extension UIViewController {
    
    func setBackground(withImageNamed image: String) {
        let backgroundImageView = UIImageView()
        view.addSubview(backgroundImageView)
        
        backgroundImageView.translatesAutoresizingMaskIntoConstraints = false
        backgroundImageView.topAnchor.constraint(equalTo: view.topAnchor).isActive = true
        backgroundImageView.leadingAnchor.constraint(equalTo: view.leadingAnchor).isActive = true
        backgroundImageView.trailingAnchor.constraint(equalTo: view.trailingAnchor).isActive = true
        backgroundImageView.bottomAnchor.constraint(equalTo: view.bottomAnchor).isActive = true
        
        backgroundImageView.contentMode = .scaleAspectFill
        
        backgroundImageView.image = UIImage(named: image)
        
        view.sendSubviewToBack(backgroundImageView)
    }
}
