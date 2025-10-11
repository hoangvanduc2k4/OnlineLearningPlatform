
document.addEventListener('DOMContentLoaded', () => {
    console.log("Demo: DOMContentLoaded");
    const bubbleBtn = document.getElementById('chat-bubble-btn');
    const chatPopup = document.getElementById('chat-popup');
    const chatClose = document.getElementById('chat-popup-close');
    const buttons = chatPopup.querySelectorAll('.chatbot-buttons button');
    const inputDiv = document.getElementById('chatbot-input');
    const textarea = document.getElementById('chatbot-textarea');
    const numQuestions = document.getElementById('num-questions');
    const summarizeSelect = document.getElementById('summarize-or-explain');
    const submitBtn = document.getElementById('submit-chatbot');
    const spinner = submitBtn.querySelector('.spinner');
    const responseDiv = document.getElementById('chatbot-response');
    let currentFunction = '';

    bubbleBtn.addEventListener('click', () => {
        console.log("Demo: bubble clicked");
        chatPopup.classList.toggle('d-none');
        console.log("Popup classes:", chatPopup.classList.toString());
    });

    chatClose.addEventListener('click', () => {
        console.log("Demo: close clicked");
        chatPopup.classList.add('d-none');
    });

    buttons.forEach(button => {
        button.addEventListener('click', () => {
            currentFunction = button.dataset.function;
            console.log("Demo: selected function:", currentFunction);
            inputDiv.classList.remove('d-none');
            if (currentFunction === 'generate-quiz') {
                numQuestions.classList.remove('d-none');
            } else {
                numQuestions.classList.add('d-none');
            }
            if (currentFunction === 'summarize') {
                summarizeSelect.classList.remove('d-none');
            } else {
                summarizeSelect.classList.add('d-none');
            }
            textarea.value = '';
            responseDiv.innerHTML = '';
            submitBtn.disabled = false;
            spinner.classList.add('d-none');
        });
    });

    submitBtn.addEventListener('click', () => {
        let question = textarea.value.trim();
        if (!question) return;
        appendMessage('Bạn', question, 'user-message');
        appendMessage('AI', 'Processing...', 'ai-message');
        submitBtn.disabled = true;
        spinner.classList.remove('d-none');
        let url = '';
        let data = {};
        switch (currentFunction) {
            case 'generate-lesson':
                url = '/chatbot/generate-lesson';
                data = { description: question };
                break;
            case 'generate-quiz':
                url = '/chatbot/generate-quiz';
                data = { checkContent: question, numQuestions: parseInt(numQuestions.value) || 5 };
                break;
            case 'ask-quiz':
                url = '/chatbot/ask-quiz';
                data = { question: question };
                break;
            case 'summarize':
                url = '/chatbot/summarize';
                data = { content: question, isSummary: summarizeSelect.value === 'true' };
                break;
        }
        $.ajax({
            url: url,
            type: 'POST',
            data: data,
            dataType: 'json',
            success: function (result) {
                console.log('Demo: Response received:', result);
                responseDiv.removeChild(responseDiv.lastChild);
                if (result.error) {
                    appendMessage('AI', `Error: ${ result.error } `, 'ai-message');
                } else {
                    let aiResponse = result.content || result.answer || result.response || 'No response data';
                    try {
                        const parsed = JSON.parse(aiResponse);
                        aiResponse = parsed.content || aiResponse;
                    } catch (e) {
                        // Nếu không phải JSON, giữ nguyên
                    }
                    aiResponse = aiResponse.replace(/\{\s*|\s*\}/g, '').replace(/\\n/g, '\n').trim();
                    appendMessage('AI', aiResponse, 'ai-message');
                }
            },
            error: function (xhr, status, error) {
                console.error('Demo: Request failed:', error);
                responseDiv.removeChild(responseDiv.lastChild);
                appendMessage('AI', `Error: ${ error || 'Could not connect to server.' } `, 'ai-message');
            },
            complete: function () {
                submitBtn.disabled = false;
                spinner.classList.add('d-none');
                responseDiv.scrollTop = responseDiv.scrollHeight;
            }
        });
    });

    function appendMessage(who, text, className) {
        const msgDiv = document.createElement('div');
        msgDiv.classList.add('message', className);
        msgDiv.textContent = who + ': ' + text;
        responseDiv.appendChild(msgDiv);
    }
});