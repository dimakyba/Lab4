package main

import (
	"bufio"
	"fmt"
	"os"
)

func main() {
	reader := bufio.NewReader(os.Stdin)
	s, _ := reader.ReadString('\n')
	// s := "(++.)(()/)дамба"
	if validate_parentheses(s) {
		fmt.Println("YES")
	} else {
		fmt.Println("NO")
	}
}

func validate_parentheses(input string) bool {
	var counter uint
	for _, c := range input {
		if c == '(' {
			counter++
		} else if c == ')' {
			if counter == 0 {
				return false
			}
			counter--
		}
	}
	return counter == 0
}
