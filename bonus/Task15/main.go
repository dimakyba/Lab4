package main

import (
	"bufio"
	"fmt"
	"os"
	"strings"
	"unicode"
)

func main() {
	reader := bufio.NewReader(os.Stdin)
	s, _ := reader.ReadString('\n')
	s1, _ := reader.ReadString('\n')
	// s := "coconut"
	// s1 := "   co\nco\t nut  "
	if remove_whitespaces(s) == remove_whitespaces(s1) {
		fmt.Println("YES")
	} else {
		fmt.Println("NO")
	}
}

/*
https://www.quora.com/What-are-the-white-spaces-in-C#:~:text=White%20spaces%20in%20C%20refer,in%20the%20C%20programming%20languag
whitespace - There is no particular symbol for whitespace. Whitespace characters are customarily:
‘ ‘ space
'\t' horizontal tab
'\n' newline
'\v' vertical tab
'\f' feed
'\r' carriage return
*/
func remove_whitespaces(input string) string {
	var sb strings.Builder
	for _, c := range input {

		if !unicode.IsSpace(c) {
			sb.WriteRune(c)
		}
	}
	return sb.String()
}
